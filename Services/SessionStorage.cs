using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPG1.Helpers;
using RPG1.Model;

namespace RPG1.Services
{
    public class SessionStorage
    {
        readonly ISession _session;
        public Random random = new Random();


        public SessionStorage(IHttpContextAccessor hca)
        {

        }
    }
}
