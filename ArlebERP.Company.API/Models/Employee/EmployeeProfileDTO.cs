namespace ArlebERP.Company.API.Models.Employee
{
    public class EmployeeProfileDTO
    {
        public int Id { get; set; }

        public string Firstname { get; set; } = null!;

        public string Lastname { get; set; } = null!;

        public string Email { get; set; } = null!;

        public List<string> Roles { get; set; } = new List<string>();

        public int CompanyId { get; set; }

        public string CompanyName { get; set; } = null!;
    }
}
