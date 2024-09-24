using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetInfo()
        {
            return Ok("Sucess!");
        }

        [HttpGet]
        public IActionResult GetDetails()
        {
            return Ok("Sucess!");
        }
    }
}
