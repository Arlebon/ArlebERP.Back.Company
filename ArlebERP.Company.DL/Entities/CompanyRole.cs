using System;
using System.Collections.Generic;
using System.Text;

namespace ArlebERP.Company.DL.Entities
{
    public class CompanyRole
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int? CompanyId { get; set; }

        public List<Permission> Permissions { get; set; } = null!;
    }
}
