using ArlebERP.Company.DAL.Database;
using ArlebERP.Company.DAL.Repositories.Interfaces;
using ArlebERP.Company.DL.Entities;
using EntityToolBox;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArlebERP.Company.DAL.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ArlebERPCompanyContext context) : base(context) { }
    }
}
