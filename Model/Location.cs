using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPG.Model;

namespace RPG.Model
{
    public class Location
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public List<Path> Paths { get; set; }
        public Location(int id, string description, List<Path> paths)
        {
            this.ID = id;
            this.Description = description;
            this.Paths = paths;
        }
    }
}
