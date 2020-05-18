using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPG.Model;

namespace RPG.Services
{
    public class GameLogic
    {
        readonly SessionStorage _session;
        readonly Game _game;

        public GameLogic(SessionStorage session, Game game)
        {
            _session = session;
            _game = game;
        }

        public Location Play(int path)
        {
            return _game.locations[path];

        }
    }
}
