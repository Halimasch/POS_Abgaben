using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fußball_Lib
{
    public class Team
    {
        private List<Player> _PlayerList;
        private DAL _DAL;

        public Team()
        {
            _DAL = new DAL();
            _PlayerList = new List<Player>();
        }

        public List<Player> LoadAllPlayers()
        {
            _PlayerList = _DAL.LoadAllPlayersDB();
            return _PlayerList;
        }

        public List<string> GetAllPlayerPositions()
        {
            List<string> list = new List<string>();


            return list;
        }
    }
}
