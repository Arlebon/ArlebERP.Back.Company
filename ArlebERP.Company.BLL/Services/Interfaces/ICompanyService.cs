using Entities = ArlebERP.Company.DL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using ArlebERP.Company.DL.Entities;

namespace ArlebERP.Company.BLL.Services.Interfaces
{
    public interface ICompanyService
    {
        public void Create(Entities.Company company, Employee employeeAdmin);
    }
}
