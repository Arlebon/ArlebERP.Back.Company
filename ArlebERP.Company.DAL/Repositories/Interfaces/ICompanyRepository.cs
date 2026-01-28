using Entities = ArlebERP.Company.DL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using EntityToolBox;

namespace ArlebERP.Company.DAL.Repositories.Interfaces
{
    public interface ICompanyRepository : IBaseRepository<Entities.Company>
    {
        public Entities.Company? GetByVatNumber(string vatNumber);
    }
}
