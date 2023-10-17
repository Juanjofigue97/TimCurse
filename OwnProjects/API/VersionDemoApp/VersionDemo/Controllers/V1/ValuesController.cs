using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VersionDemo.Controllers.V1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        [MapToApiVersion("1.0")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpGet]
        [MapToApiVersion("2.0")]
        public IEnumerable<string> GetV1()
        {
            return new string[] { "Version value1", "value2" };
        }
    }
}
