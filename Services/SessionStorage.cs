using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPG.Model;
using RPG.Helpers;

namespace RPG.Services
{
    public class SessionStorage
    {
        readonly ISession _session;
        const string KEY = "LOCATION";
        const string PLAYER = "PLAYER";
        public Player _player { get; set; }
        public SessionStorage(IHttpContextAccessor hca)
        {
            _session = hca.HttpContext.Session;
            _player = _session.Get<Player>(PLAYER);
        }

        public void SavePlayer(Player player)
        {
            _session.Set(PLAYER, player);
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
