using Microsoft.AspNetCore.Mvc;
using PeopleModelAPI.Model;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PeopleModelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly ILogger _logger;

        public AddressesController(ILogger<AddressesController> logger)
        {
            _logger = logger;
        }
        // GET: api/<AddressesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AddressesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AddressesController>
        [HttpPost]
        public void Post([FromBody] AddressesModel addresses)
        {
            _logger.LogInformation("Our message was {Address}", addresses.City);
        }

        // PUT api/<AddressesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AddressesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
