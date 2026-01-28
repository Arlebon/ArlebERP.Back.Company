using System;
using System.Collections.Generic;
using System.Text;

namespace ArlebERP.Company.DL.Entities
{
    public class Permission
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Code { get; set; } = null!;
    }
}
