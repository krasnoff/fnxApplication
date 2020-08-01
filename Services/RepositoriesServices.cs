using fnxApplication.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace fnxApplication.Services
{
    public class RepositoriesServices
    {
        public List<Repository> getRepository(string searchWord)
        {
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            Stream data = client.OpenRead("https://api.github.com/search/repositories?q=" + HttpUtility.UrlEncode(searchWord));
            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();

            RawRepositories result = JsonConvert.DeserializeObject<RawRepositories>(s);

            var res = result.items.Select(x => new Repository()
            {
                id = x.id,
                full_name = x.full_name,
                description = x.description,
                avatar_url = x.owner.avatar_url,
                name = x.name
            }).ToList();

            data.Close();
            reader.Close();

            return res;
        }
    }
}
