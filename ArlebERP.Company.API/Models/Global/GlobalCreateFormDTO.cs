using ArlebERP.Company.API.Models.Company;
using ArlebERP.Company.API.Models.Employee;
using System.ComponentModel.DataAnnotations;

namespace ArlebERP.Company.API.Models.Global
{
    public class GlobalCreateFormDTO
    {
        [Required]
        public CompanyFormDTO companyForm { get; set; } = null!;

        [Required]
        public EmployeeFormDTO adminForm { get; set; } = null!;
    }
}
