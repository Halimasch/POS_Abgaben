using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace TS12
{
    public class DAL
    {
        private string m_file;

        public DAL()
        {
            m_file = @"textfiles\test.txt";
        }

        public Lehrer[] GetTeachersFromFile()
        {
            StreamReader reader = new StreamReader(m_file);
            Lehrer[] lehrer = new Lehrer[3];
            int cnt = 0;

            while(reader.EndOfStream == false) // while(!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] parts = line.Split(' ');

                if(parts[0] == "Lehrer")
                {
                    line = reader.ReadLine();
                    parts = line.Split(' ');

                    lehrer[cnt] = new Lehrer(parts[1], parts[2], parts[0]);
                    cnt++;
                }
            }
            return lehrer;
        }

        public string[] GetSubject(string kz)
        {
            StreamReader reader = new StreamReader(m_file);

            string[] subj = new string[10];
            int cnt = 0;

            while(reader.EndOfStream == false)
            {
                string line = reader.ReadLine();
                if (line.Contains(kz))
                {
                    line = reader.ReadLine();

                    if (line.Contains("Fächer"))
                    {
                        line = reader.ReadLine();
                        string[] parts = line.Split(' ');
                        foreach(string s in parts)
                        {
                            subj[cnt++] = s + " ";
                        }
                    }
                }
            }
            reader.Close();
            return subj;
        }
    }
}
