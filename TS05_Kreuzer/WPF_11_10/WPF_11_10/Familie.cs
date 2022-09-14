using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_11_10
{
    public class Familie
    {
        private string m_Name;
        private string m_Mann;
        private string m_Frau;

        public Familie()
        {
            // leer
        }

        public Familie(string name, string mann, string frau)
        {
            m_Name = name;
            m_Mann = mann;
            m_Frau = frau;
        }

        public string Name { get => m_Name; set => m_Name = value; }

        public string Mann { get => m_Mann; set => m_Mann = value; }

        public string Frau { get => m_Frau; set => m_Frau = value; }

        public override string ToString()
        {
            return $"Familie: {m_Name}; Herr {m_Mann} - Frau {m_Frau}";
        }
    }
}