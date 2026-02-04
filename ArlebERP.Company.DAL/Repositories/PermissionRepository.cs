using ArlebERP.Company.DAL.Database;
using ArlebERP.Company.DAL.Repositories.Interfaces;
using ArlebERP.Company.DL.Entities;
using EntityToolBox;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArlebERP.Company.DAL.Repositories
{
    public class PermissionRepository : BaseRepository<Permission>, IPermissionRepository
    {
        public PermissionRepository(ArlebERPCompanyContext context) : base(context) { }
    }
}
