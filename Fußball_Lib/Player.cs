using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fußball_Lib
{
    public class Player
    {
        private int _ID;
        private string _Name;
        private string _Position;
        private Address _Adresse;
        private int _Bonus;

        public int ID { get => _ID; set => _ID = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Position { get => _Position; set => _Position = value; }
        public Address Adresse { get => _Adresse; set => _Adresse = value; }
        public int Bonus { get => _Bonus; set => _Bonus = value; }
    }
}
