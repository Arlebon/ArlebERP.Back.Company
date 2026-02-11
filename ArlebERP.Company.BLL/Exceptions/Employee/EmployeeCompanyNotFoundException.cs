using System;
using System.Collections.Generic;
using System.Text;

namespace ArlebERP.Company.BLL.Exceptions.Employee
{
    public class EmployeeCompanyNotFoundException: NotFoundException
    {
        public EmployeeCompanyNotFoundException(string message): base(message) { }

        public EmployeeCompanyNotFoundException() : base("User doesn't have a company") { }
    }
}
