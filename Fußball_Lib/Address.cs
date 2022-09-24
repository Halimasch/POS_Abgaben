using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fußball_Lib
{
    public class Address
    {
        private string _Street;
        private int _ZIP;
        private string _City;

        public string Street { get => _Street; set => _Street = value; }
        public int ZIP { get => _ZIP; set => _ZIP = value; }
        public string City { get => _City; set => _City = value; }

        public override string ToString()
        {
            return $"Address: {_Street} in {_ZIP} {_City}";
        }

      
    }
}
