using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RPG.Services;
using RPG.Models;

namespace RPG.Pages
{
    public class Game : PageModel
    {
        public readonly SessionStorage _ss;
        public readonly Services.Game _place;
        [BindProperty]
        public int index { get; set; }
        public Game(SessionStorage ss)
        {
            _ss = ss;
            _place = new Services.Game(ss);
            index = 0;
        }
        public void OnGet()
        {
         
        }
        public void OnPost()
        {

        }
    }
}