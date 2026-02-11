using ArlebERP.Company.BLL.Exceptions.Employee;
using ArlebERP.Company.BLL.Services.Interfaces;
using ArlebERP.Company.DAL.Repositories.Interfaces;
using ArlebERP.Company.DL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArlebERP.Company.BLL.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Employee GetByUserId(int userId)
        {
            Employee? employee = _employeeRepository.GetByUserId(userId);

            if (employee == null)
            {
                throw new EmployeeCompanyNotFoundException();
            }

            return employee;
        }
    }
}
