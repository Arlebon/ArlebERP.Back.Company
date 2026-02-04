using System;
using System.Collections.Generic;
using System.Text;

namespace ArlebERP.Company.DL.Entities
{
    public class Address
    {
        public string Street { get; set; } = null!;

        public string StreetNumber { get; set; } = null!;

        public string City { get; set; } = null!;

        public string ZipCode { get; set; } = null!;

        public string Country { get; set; } = null!;

        public string? BoxNumber { get; set; }

    }
}
