using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPG1.Model;

namespace RPG1.Services
{
    public class Game
    {
        public Game()
        {
            Player player = new Player();
            player.HP = 10;
            player.Dmg = 0.5;

            List<Location> locations = new List<Location>();
            locations.Add(new Location() { ID = 1, Name = "Vesnice", Description = "Nacházíš se ve vesnici." });
            locations.Add(new Location() { ID = 2, Name = "Farma", Description = "Nacházíš se na farmě." });
            locations.Add(new Location() { ID = 3, Name = "Stodola", Description = "Nacházíš se ve stodole." });
        }
    }
}
