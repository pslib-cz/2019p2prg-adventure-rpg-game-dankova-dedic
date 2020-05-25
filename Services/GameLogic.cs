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
            switch (path)
            {
                case 0:
                    _player.HP = 10;
                    break;
                case 16:
                    _player.Sword = true;
                    break;
                case 25:
                    _player.Sword = false;
                    _player.HP -= 2;
                    break;
                case 19:
                case 24:
                case 26:
                    _player.HP = 0;
                    break;
                case 17:
                    _player.HP -= 5;
                    break;
                case 21:
                    _player.HP -= 4;
                    break;
            }

            if(path == 38 && _player.Sword == false)
            {
                 path = 42;
            }

            _session.SavePlayer(_player);
            return _game.locations[path];

        }
    }
}
