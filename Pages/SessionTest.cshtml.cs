using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RPG.Model;
using RPG.Services;

namespace RPG.Pages
{
    public class SessionTestModel : PageModel
    {
        private readonly SessionStorage _ss;

        public Player Player { get; set; }

        public SessionTestModel(SessionStorage ss)
        {
            _ss = ss;
        }

        public void OnGet()
        {
            Player = _ss._player;
        }

        public IActionResult OnGetCreatePlayer()
        {
            _ss.SavePlayer(new Player() { HP = 10, Sword = true });

            return RedirectToPage();
        }


    }
}