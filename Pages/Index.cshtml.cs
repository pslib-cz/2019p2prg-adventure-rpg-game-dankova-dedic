using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RPG.Services;
using RPG.Models;

namespace RPG.Pages
{
    public class IndexModel : PageModel
    {
        public readonly SessionStorage _ss;
        public IndexModel(SessionStorage ss)
        {
            _ss = ss;
        }

        public void OnGet()
        {

        }
        public ActionResult OnPost()
        {
            return RedirectToPage("./Game");
        }
    }
}
