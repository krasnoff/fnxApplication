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
        // GET: api/Repositories/5
        [HttpGet("{searchWord}", Name = "Get")]
        public List<Repository> Get(string searchWord)
        {
            RepositoriesServices service = new RepositoriesServices();
            return service.getRepository(searchWord);
        }

        // POST: api/addBookmark
        [HttpPost("addBookmark")]
        public IActionResult addBookmark([FromBody] Repository item)
        {
            List<Repository> repository = new List<Repository>();
            string sessionData = HttpContext.Session.GetString("bookmarkList");
            if (!String.IsNullOrEmpty(sessionData)) {
                repository = JsonConvert.DeserializeObject<List<Repository>>(sessionData);
            }

            repository.Add(item);
            string bookmarkStr = JsonConvert.SerializeObject(repository);
            HttpContext.Session.SetString("bookmarkList", bookmarkStr);

            return Ok("{\"res\": \"session data set\"}");
        }

        // GET: api/Repositories/getBookmarks
        [HttpGet("getBookmarks")]
        public IActionResult getBookmarks()
        {
            string sessionData = HttpContext.Session.GetString("bookmarkList");
            if (String.IsNullOrEmpty(sessionData))
            {
                sessionData = "[]";
            }
            return Ok(sessionData);
        }
    }
}
