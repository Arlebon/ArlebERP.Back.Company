using System;
using System.Collections.Generic;
using System.Text;

namespace ArlebERP.Company.DL.Entities
{
    public class Company
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string VatNumber { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public Address HeadquarterAddress { get; set; } = null!;

        public List<Employee> Employees { get; set; } = null!;
    }
}
