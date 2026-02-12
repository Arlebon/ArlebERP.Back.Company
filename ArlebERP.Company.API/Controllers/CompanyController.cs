using ArlebERP.Company.API.Mappers;
using ArlebERP.Company.API.Models.Company;
using ArlebERP.Company.API.Models.Global;
using ArlebERP.Company.BLL.Services.Interfaces;
using ArlebERP.Company.DL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ArlebERP.Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpPost("create-company")]
        [Authorize]
        public ActionResult CreateCompany([FromBody] GlobalCreateFormDTO form)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            int userId = int.Parse(User.FindFirstValue(ClaimTypes.Sid)!);
            Employee employee = form.AdminForm.ToEmployee();
            employee.UserId = userId;

            _companyService.Create(form.CompanyForm.ToCompany(), employee);

            return Created();
        }

        [HttpPost("join-company")]
        [Authorize]
        public ActionResult JoinCompany([FromBody] JoinRequestVatDTO form)
        {
            int userId = int.Parse(User.FindFirstValue(ClaimTypes.Sid)!);

            _companyService.CreateJoinRequest(form.VatNumber, userId);

            return Created();
        }
    }
}
