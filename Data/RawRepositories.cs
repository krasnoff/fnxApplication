using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fnxApplication.Data
{
    public class RawRepositories
    {
        public int total_count { get; set; }
        public bool incomplete_results { get; set; }
        public List<Item> items { get; set; }
    }

    public class Item
    {
        public string id { get; set; }
        public string full_name { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public Owner owner { get; set; }
    }

    public class Owner
    {
        public string avatar_url { get; set; }
    }
}
