using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace personapi_dotnet.Controllers.API
{
    [Route("api/profesiones")]
    [ApiController]
    public class ProfesionControllerAPI : ControllerBase
    {
        // GET: api/<ProfesionControllerAPI>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ProfesionControllerAPI>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProfesionControllerAPI>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProfesionControllerAPI>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProfesionControllerAPI>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
