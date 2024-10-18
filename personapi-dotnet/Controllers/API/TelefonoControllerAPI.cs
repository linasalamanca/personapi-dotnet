    using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace personapi_dotnet.Controllers.API
{
    [Route("api/telefonos")]
    [ApiController]
    public class TelefonoControllerAPI : ControllerBase
    {
        // GET: api/<TelefonoControllerAPI>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TelefonoControllerAPI>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TelefonoControllerAPI>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TelefonoControllerAPI>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TelefonoControllerAPI>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
