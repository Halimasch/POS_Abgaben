using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS01_Shop
{
    public class Artikel
    {
        private int _ArtID;

        public int ArtID
        {
            get { return _ArtID; }
            set { _ArtID = value; }
        }

        private int _Menge;

        public int Menge
        {
            get { return _Menge; }
            set { _Menge = value; }
        }

        private string _Bezeichnung;

        public string Bezeichnung
        {
            get { return _Bezeichnung; }
            set { _Bezeichnung = value; }
        }

        private float _Preis;

        public float Preis
        {
            get { return _Preis; }
            set { _Preis = value; }
        }

    }
}
