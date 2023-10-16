using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VersionDemo.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersionNeutral]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        [Route("ping")]
        public IActionResult Ping() 
        {
            return Ok("Everything seems great!");
        }
    }
}
