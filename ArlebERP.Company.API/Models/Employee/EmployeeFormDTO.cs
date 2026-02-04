using ArlebERP.Company.DL.Entities;
using System.ComponentModel.DataAnnotations;

namespace ArlebERP.Company.API.Models.Employee
{
    public class EmployeeFormDTO
    {
        [Required]
        [MaxLength(255)]
        public string Firstname { get; set; } = null!;

        [Required]
        [MaxLength(255)]
        public string Lastname { get; set; } = null!;

        [Required]
        [MaxLength(255)]
        public string Email { get; set; } = null!;

        [Required]
        [MaxLength(15)]
        public string Phone { get; set; } = null!;

        [Required]
        public Address Address { get; set; } = null!;
    }
}
