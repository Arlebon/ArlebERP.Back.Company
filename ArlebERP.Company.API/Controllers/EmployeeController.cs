using ArlebERP.Company.API.Mappers;
using ArlebERP.Company.API.Models.Employee;
using ArlebERP.Company.BLL.Services.Interfaces;
using ArlebERP.Company.DL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ArlebERP.Company.API.Controllers
{
    [Route("api/Company/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("me")]
        [Authorize]
        public ActionResult GetEmployeeByUser()
        {
            int userId = int.Parse(User.FindFirstValue(ClaimTypes.Sid)!);

            EmployeeProfileDTO employee = _employeeService.GetByUserId(userId).ToEmployeeProfile();

            return Ok(employee);
        }
    }
}
