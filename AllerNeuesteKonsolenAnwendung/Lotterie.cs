using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllerNeuesteKonsolenAnwendung
{
    public class Lotterie
    {
        //private DAL _DAL;
        private List<int> _Tipps;

        public Lotterie(List<int> tipps)
        {
            _Tipps = tipps;
        }

        public List<int> GetTipps()
        {
            return _Tipps;
        }

        public int Tipp1 { get => _Tipps[0]; }
        public int Tipp2 { get => _Tipps[1]; }
        public int Tipp3 { get => _Tipps[2]; }



    }
}
