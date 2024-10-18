using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace personapi_dotnet.Controllers.API
{
    [Route("api/personas")]
    [ApiController]
    public class PersonasControllerAPI : ControllerBase
    {
        // GET: api/<PersonasControllerAPI>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PersonasControllerAPI>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PersonasControllerAPI>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PersonasControllerAPI>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonasControllerAPI>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
