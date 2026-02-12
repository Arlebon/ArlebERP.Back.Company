using System;
using System.Collections.Generic;
using System.Text;

namespace ArlebERP.Company.BLL.Exceptions.CompanyJoinRequest
{
    public class CompanyJoinRequestAlreadyExistsException : AlreadyExistsException
    {
        public CompanyJoinRequestAlreadyExistsException(string message) : base(message) { }

        public CompanyJoinRequestAlreadyExistsException() : base("Join request already made") { }
    }
}
