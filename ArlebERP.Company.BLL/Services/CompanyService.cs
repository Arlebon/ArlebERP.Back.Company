using Entities = ArlebERP.Company.DL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using ArlebERP.Company.DAL.Repositories.Interfaces;

namespace ArlebERP.Company.BLL.Services
{
    public class CompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository) 
        {
            _companyRepository = companyRepository;
        }

        public void Create(Entities.Company company)
        {
            if(_companyRepository.GetByVatNumber(company.VatNumber) != null)
            {
                throw new NotImplementedException();
            }

            _companyRepository.Add(company);
        }
    }
}
