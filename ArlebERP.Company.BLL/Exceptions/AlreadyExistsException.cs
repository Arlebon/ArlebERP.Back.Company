using System;
using System.Collections.Generic;
using System.Text;

namespace ArlebERP.Company.BLL.Exceptions
{
    public class AlreadyExistsException : ArlebERPCompanyException
    {
        public AlreadyExistsException(object content) : base(409, content) { }
    }
}
