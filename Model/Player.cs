using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Model
{
    public class Player
    {
        public int HP { get; set; } = 10;
        public bool Sword { get; set; } = false;

        public bool Trenky { get; set; } = true;
    }
}