using System;
using System.Collections.Generic;
using System.Text;

namespace ArlebERP.Company.BLL.Exceptions
{
    public class ArlebERPCompanyException: Exception
    {
        public int StatusCode { get; set; }

        public object Content { get; set; }

        public ArlebERPCompanyException(int statusCode, object content)
        {
            StatusCode = statusCode;
            Content = content;
        }
    }
}
