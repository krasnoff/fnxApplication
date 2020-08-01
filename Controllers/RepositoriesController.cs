using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using fnxApplication.Data;
using fnxApplication.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace fnxApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepositoriesController : ControllerBase
    {
        // GET: api/Repositories
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Repositories/5
        [HttpGet("{searchWord}", Name = "Get")]
        public List<Repository> Get(string searchWord)
        {
            RepositoriesServices service = new RepositoriesServices();
            return service.getRepository(searchWord);
        }

        // POST: api/Repositories
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Repositories/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
