using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TS01_Shop;

namespace Project_TS01_WCF
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Klassennamen "Service1" sowohl im Code als auch in der SVC- und der Konfigurationsdatei ändern.
    // HINWEIS: Wählen Sie zum Starten des WCF-Testclients zum Testen dieses Diensts Service1.svc oder Service1.svc.cs im Projektmappen-Explorer aus, und starten Sie das Debuggen.
    public class Service1 : IService1
    {
        public List<string> GetAllCompaniesSvc()
        {
            Firma f = new Firma();
            return f.GetAllCompanies();
        }

        public List<Artikel> GetAllArticlesFromSvc(string firma)
        {
            Firma f = new Firma();
            return f.GetAllArticlesFromFirma(firma);
        }

     
    }
}
