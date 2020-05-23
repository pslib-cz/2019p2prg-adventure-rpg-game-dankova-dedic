using Microsoft.AspNetCore.Http;
using RPG.Helpers;
using RPG.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Services
{
    public class GameLogic
    {
        readonly SessionStorage _session;
        readonly Game _game;
        public Player _player { get; set; }

        public GameLogic(SessionStorage session, Game game)
        {
            _session = session;
            _game = game;
            _player = new Player() { HP = _session._player.HP, Sword = _session._player.Sword };
        }

        public Location Play(int path)
        {
            _session.SavePlayer(_player);
            return _game.locations[path];

        }

        public void Weapon()
        {
            _player.Sword = true;
            _session.SavePlayer(_player);
        }
    }
}
