using Entities = ArlebERP.Company.DL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using ArlebERP.Company.DAL.Repositories.Interfaces;
using ArlebERP.Company.DL.Entities;
using ArlebERP.Company.BLL.Services.Interfaces;
using ArlebERP.Company.BLL.Exceptions.Company;
using ArlebERP.Company.DL.Enums;

namespace ArlebERP.Company.BLL.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly ICompanyRoleRepository _companyRoleRepository;
        private readonly ICompanyJoinRequestRepository _companyJoinRequestRepository;

        public CompanyService(ICompanyRepository companyRepository, ICompanyRoleRepository companyRoleRepository, ICompanyJoinRequestRepository companyJoinRequestRepository) 
        {
            _companyRepository = companyRepository;
            _companyRoleRepository = companyRoleRepository;
            _companyJoinRequestRepository = companyJoinRequestRepository;
        }

        public void Create(Entities.Company company, Employee employeeAdmin)
        {
            if(_companyRepository.GetByVatNumber(company.VatNumber) != null)
            {
                throw new NotImplementedException();
            }

            CompanyRole? adminRole = _companyRoleRepository.GetOne(1);

            if(adminRole == null)
            {
                throw new NotImplementedException(); 
            }

            employeeAdmin.Company = company;
            employeeAdmin.Roles.Add(adminRole);
            company.Employees.Add(employeeAdmin);

            _companyRepository.Add(company);
            
        }

        public void CreateJoinRequest(string vatNumber, int userId)
        {
            Entities.Company? company = _companyRepository.GetByVatNumber(vatNumber);

            if(company == null)
            {
                throw new CompanyNotFoundException("Company with this VAT number doesn't exists");
            }

            CompanyJoinRequest request = new CompanyJoinRequest
            {
                UserId = userId,
                CompanyId = company.Id,
                Date = DateTimeOffset.Now,
                Status = JoinRequestStatus.Pending,
            };

            _companyJoinRequestRepository.Add(request);
        }
    }
}
