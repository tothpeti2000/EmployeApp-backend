using Domain.Models.Department;
using Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : BaseController<DepartmentService, Department, DepartmentFormData>
    {
        public DepartmentsController(DepartmentService service) : base(service)
        { }
    }
}
