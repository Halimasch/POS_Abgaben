using System;

namespace TS12
{
    public class Program
    {
        static void Main(string[] args)
        {
            Schule school = new Schule();

            school.GetTeachersFromDAL();

            // 2.
            Console.WriteLine("Alle Lehrer: ");

            string[] lehrer = school.GetTeachersFromSchool();

            for(int i = 0; i < lehrer.Length; i++)
            {
                Console.WriteLine($"\t{lehrer[i]}");
            }

            // 3.
            Console.WriteLine("\nAlle Lehrer Kurzzeichen");

            string[] kurzzeichen = school.GetTeachersShortCut();
            foreach(string s in kurzzeichen)
            {
                Console.WriteLine($"\t{s}");
            }

            // 4.
            foreach(string kz in kurzzeichen)
            {
                if (kz.Contains("MA"))
                {
                    string s = school.GetTeacherAndSubjects(kz);
                    Console.WriteLine($"{s} \n");
                }
                
            }


        }
    }
}
