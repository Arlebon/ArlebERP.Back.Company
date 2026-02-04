using Entities = ArlebERP.Company.DL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using ArlebERP.Company.DAL.Repositories.Interfaces;
using ArlebERP.Company.DL.Entities;
using ArlebERP.Company.BLL.Services.Interfaces;

namespace ArlebERP.Company.BLL.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly ICompanyRoleRepository _companyRoleRepository;

        public CompanyService(ICompanyRepository companyRepository, ICompanyRoleRepository companyRoleRepository) 
        {
            _companyRepository = companyRepository;
            _companyRoleRepository = companyRoleRepository;
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
    }
}
