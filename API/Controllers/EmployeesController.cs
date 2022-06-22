using Domain.Models;
using Domain.Models.Employee;
using Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : BaseController<EmployeeService, Employee, EmployeeFormData>
    {
        public EmployeesController(EmployeeService service) : base(service)
        { }
    }
}
