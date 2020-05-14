using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPG.Helpers;
using RPG.Models;

namespace RPG.Services
{
    public class SessionStorage
    {
        readonly ISession _session;
        public SessionStorage(IHttpContextAccessor hca)
        {
            _session = hca.HttpContext.Session;            
        }
    }
}
