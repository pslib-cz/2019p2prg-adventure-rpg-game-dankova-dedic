using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Models
{
    public class Location
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string Way { get; set; }
        public int[] Path { get; set; }
        public Location(int id, int[] paths, string way, string description)
        {
            this.ID = id;
            this.Path = paths;
            this.Way = way;
            this.Description = description;
        }
    }
}
