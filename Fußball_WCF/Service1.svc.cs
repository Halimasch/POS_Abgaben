using Fußball_Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Fußball_WCF
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Klassennamen "Service1" sowohl im Code als auch in der SVC- und der Konfigurationsdatei ändern.
    // HINWEIS: Wählen Sie zum Starten des WCF-Testclients zum Testen dieses Diensts Service1.svc oder Service1.svc.cs im Projektmappen-Explorer aus, und starten Sie das Debuggen.
    public class Service1 : IService1
    {
        private DAL _DAL;
        public List<Player> GetAllPlayers()
        {
            List<Player> playerlist = _DAL.LoadAllPlayersDB();
            return playerlist;
        }
    }
}
