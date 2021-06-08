using System;
using System.Collections.Generic;
using System.Text;

namespace TS12
{
    public class Lehrer
    {
        private string m_Vorname;
        private string m_Nachname;
        private string m_Kurzzeichen;

        public Lehrer(string firstname, string lastname, string vz)
        {
            this.m_Vorname = firstname;
            this.m_Nachname = lastname;
            this.m_Kurzzeichen = vz;
        }

        public override string ToString()
        {
            return $"{m_Kurzzeichen} {m_Vorname} {m_Nachname}";
        }

        public string GetShortCut()
        {
            return m_Kurzzeichen;
        }
        public string GetLastname()
        {
            return m_Nachname;
        }
    }
}
