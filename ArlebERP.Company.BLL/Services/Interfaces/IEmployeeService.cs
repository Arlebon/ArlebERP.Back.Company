using ArlebERP.Company.DL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArlebERP.Company.BLL.Services.Interfaces
{
    public interface IEmployeeService
    {
        public Employee GetByUserId(int userId);
    }
}
