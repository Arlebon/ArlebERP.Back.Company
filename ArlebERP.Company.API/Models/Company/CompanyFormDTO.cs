using ArlebERP.Company.DL.Entities;
using System.ComponentModel.DataAnnotations;

namespace ArlebERP.Company.API.Models.Company
{
    public class CompanyFormDTO
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(20)]
        public string VatNumber { get; set; } = null!;

        [Required]
        [MaxLength(255)]
        public string Email { get; set; } = null!;

        [Required]
        [MaxLength(15)]
        public string Phone { get; set; } = null!;

        [Required]
        public Address HeadquarterAddress { get; set; } = null!;
    }
}
