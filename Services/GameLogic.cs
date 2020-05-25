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
            if (path == 16)
            {
                _player.Sword = true;
            }

            if(path == 17)
            {
                _player.HP -= 5;

            }
            if(path == 21)
            {
                _player.HP -= 4;
            }
            if(path == 19 || path == 24 || path == 26)
            {
                _player.HP = 1;
            }
            if(path == 25 || path == 38)
            {
                _player.HP -= 2;
            }
            _session.SavePlayer(_player);
            return _game.locations[path];

        }
    }
}
