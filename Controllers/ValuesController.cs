using System.Collections.Generic;
using appMetrics.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace appMetrics.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        // GET: api/values
        [HttpGet]
        [Route("Get")] 
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/values/5
        [HttpGet]
        [Route("GetById")] 
        public string GetById(int id)
        {
            throw new ValueNotFoundException();
        }

        // POST: api/values
         [HttpPost]
        public void Post([FromBody] string value)
        {
            throw new PostException();
        }

        // PUT: api/values/5
        [HttpPut]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/values/5
        [HttpDelete]
        public void Delete(int id)
        {
            throw new DeleteException();
        }
    }
}