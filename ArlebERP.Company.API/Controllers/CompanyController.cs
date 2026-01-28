using ArlebERP.Company.BLL.Services;

namespace ArlebERP.Company.API.Controllers
{
    public class CompanyController
    {
        private readonly CompanyService _companyService;

        public CompanyController(CompanyService companyService)
        {
            _companyService = companyService;
        }
    }
}
