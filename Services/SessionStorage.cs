using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPG.Model;

namespace RPG.Services
{
    public class SessionStorage
    {
        readonly ISession _session;
        const string KEY = "LOCATION";
        public SessionStorage(IHttpContextAccessor hca)
        {
            _session = hca.HttpContext.Session;            
        }

        public void SetLocationId(int number)
        {
            _session.SetInt32(KEY, number);
        }

        public int? GetLocationId()
        {
            return _session.GetInt32(KEY);
        }
    }
}
