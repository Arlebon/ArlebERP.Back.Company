using ArlebERP.Company.API.Models.Employee;
using ArlebERP.Company.DL.Entities;

namespace ArlebERP.Company.API.Mappers
{
    public static class EmployeeMapper
    {
        public static Employee ToEmployee(this EmployeeFormDTO form)
        {
            return new Employee()
            {
                Firstname = form.Firstname,
                Lastname = form.Lastname,
                Email = form.Email,
                Phone = form.Phone,
                Address = form.Address,
                Roles = new List<CompanyRole>(),
            };
        }

        public static EmployeeProfileDTO ToEmployeeProfile(this Employee employee)
        {
            return new EmployeeProfileDTO()
            {
                Firstname = employee.Firstname,
                Lastname = employee.Lastname,
                Email = employee.Email,
                Roles = employee.Roles.Select(r => r.Name).ToList(),
                CompanyId = employee.CompanyId,
                CompanyName = employee.Company.Name,
            };
        }
    }
}
