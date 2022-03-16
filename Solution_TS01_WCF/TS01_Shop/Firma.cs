using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TS01_Shop
{
    public class Firma
    {
        // Member
        private XmlDocument _xmlDocument;
        private string _xmlPath;

        public Firma()
        {
            _xmlDocument = new XmlDocument();
            _xmlPath = @"C:\dev\POS-Ingenium\Solution_TS01_WCF\Project_TS01_WCF\App_Data\Bestellung.xml";
        }

        public List<string> GetAllCompanies()
        {
            var compList = new List<string>();

            _xmlDocument.Load(_xmlPath);

            XmlNodeList nodeList = _xmlDocument.GetElementsByTagName("Firma");

            foreach (XmlNode node in nodeList)
            {
                // Firstchild sonst wird der ganze InnerText zwischen Firma ausgegeben
                compList.Add(node.FirstChild.InnerText);
            }
            return compList;
        }

        public List<Artikel> GetAllArticlesFromFirma(string firma)
        {
            var artList = new List<Artikel>();

            _xmlDocument.Load(_xmlPath);

            XmlNodeList nodeList = _xmlDocument.GetElementsByTagName("Firma");

            foreach (XmlNode node in nodeList)
            {
                if (node.FirstChild.InnerText == firma)
                {
                    foreach (XmlNode xmlNode in node.ChildNodes.Item(1))
                    {
                        artList.Add(new Artikel
                        {
                            ArtID = Convert.ToInt32(xmlNode.Attributes.GetNamedItem("ArtID").Value),
                            Menge = Convert.ToInt32(xmlNode.Attributes.GetNamedItem("Menge").Value),
                            Bezeichnung = xmlNode.InnerText,
                            Preis = Convert.ToSingle(xmlNode.Attributes.GetNamedItem("Preis").Value)
                        });
                    }
                }
            }
            return artList;


        }
    }
}
