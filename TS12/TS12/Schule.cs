using System;
using System.Collections.Generic;
using System.Text;

namespace TS12
{
    public class Schule
    {
        private Lehrer[] m_Lehrer;
        private DAL m_DAL;
        private int m_AktLehrer;

        public Schule()
        {
            m_DAL = new DAL();
            m_Lehrer = new Lehrer[50];
            m_AktLehrer = 0;
        }

        public void GetTeachersFromDAL()
        {
            Lehrer[] lehrer = m_DAL.GetTeachersFromFile();
            foreach (Lehrer l in lehrer)
            {
                m_Lehrer[m_AktLehrer++] = l;
            }
        }

        public string[] GetTeachersFromSchool()
        {
            string[] data = new string[m_AktLehrer];

            for(int i = 0; i < m_AktLehrer; i++)
            {
                data[i] = m_Lehrer[i].ToString();
            }
            return data;
        }

        public string[] GetTeachersShortCut()
        {
            string[] data = new string[m_AktLehrer];

            for(int i = 0; i < m_AktLehrer; i++)
            {
                data[i] = m_Lehrer[i].GetShortCut();
            }
            return data;
        }

        public string GetTeacherAndSubjects(string kz)
        {
            string data = "";

            foreach(Lehrer l in m_Lehrer)
            {
                if(l != null)
                {
                    if(l.GetShortCut() == kz)
                    {
                        data = "$Alle Fächer des Lehrers " + l.ToString() + "\n\t";

                        foreach(string s in m_DAL.GetSubject(kz)) 
                        {
                            data += s;
                        }
                    }
                }
            }
            return data;
        }



    }
}
