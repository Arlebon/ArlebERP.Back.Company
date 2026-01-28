using Entities = ArlebERP.Company.DL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using EntityToolBox;
using ArlebERP.Company.DAL.Database;
using ArlebERP.Company.DAL.Repositories.Interfaces;

namespace ArlebERP.Company.DAL.Repositories
{
    public class CompanyRepository : BaseRepository<Entities.Company>, ICompanyRepository
    {
        public CompanyRepository(ArlebERPCompanyContext context) : base(context) { }

        public Entities.Company? GetByVatNumber(string vatNumber)
        {
            return _set.FirstOrDefault(c => c.VatNumber == vatNumber);
        }
    }
}
