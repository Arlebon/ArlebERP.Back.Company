using System;
using System.Collections.Generic;
using System.Text;

namespace ArlebERP.Company.BLL.Exceptions
{
    public class NotFoundException: ArlebERPCompanyException
    {
        public NotFoundException(object content): base(404, content) { }
    }
}
