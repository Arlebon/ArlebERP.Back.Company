using System;
using System.Collections.Generic;
using System.Text;

namespace ArlebERP.Company.DL.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        public string Firstname { get; set; } = null!;

        public string Lastname { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public Address Address { get; set; } = null!;

        public List<CompanyRole> Roles { get; set; } = null!;

        public int CompanyId { get; set; }

        public Company Company { get; set; } = null!;

        public int? UserId { get; set; }
    }
}
