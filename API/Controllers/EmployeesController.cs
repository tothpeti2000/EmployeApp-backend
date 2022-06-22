using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        public EmployeesController()
        {

        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok();
        }
    }
}
