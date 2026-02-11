using System;
using System.Collections.Generic;
using System.Text;

namespace ArlebERP.Company.BLL.Exceptions.Company
{
    public class CompanyNotFoundException: NotFoundException
    {
        public CompanyNotFoundException(string message) : base(message) { }

        public CompanyNotFoundException() : base("This company doesn't exists") { }
    }
}
