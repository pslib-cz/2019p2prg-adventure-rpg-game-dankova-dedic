using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RPG.Services;
using RPG.Model;

namespace RPG.Pages
{
    public class Game : PageModel
    {
        public Location Location { get; set; }
        public GameLogic _gamelogic;
        public SessionStorage _session;

        public Game(GameLogic gamelogic, SessionStorage session)
        {
            _gamelogic = gamelogic;
            _session = session;
        }

        public void OnGet(int to)
        {
            Location = _gamelogic.Play(to);
        }
    }
}