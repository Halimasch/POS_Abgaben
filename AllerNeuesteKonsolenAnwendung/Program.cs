using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllerNeuesteKonsolenAnwendung
{
    public class Program
    {
        static void Main(string[] args)
        {
            DAL dal = new DAL();
            dal.GenerateNewDOM();
            dal.SaveDOM();
        }
    }
}
