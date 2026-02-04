using ArlebERP.Company.API.Models.Company;
using ArlebERP.Company.DL.Entities;
using Entities = ArlebERP.Company.DL.Entities;

namespace ArlebERP.Company.API.Mappers
{
    public static class CompanyMapper
    {
        public static Entities.Company ToCompany(this CompanyFormDTO form)
        {
            return new Entities.Company()
            {
                Name = form.Name,
                VatNumber = form.VatNumber,
                Email = form.Email,
                Phone = form.Phone,
                HeadquarterAddress = form.HeadquarterAddress,
                Employees = new List<Employee>(),
            };
        }
    }
}
