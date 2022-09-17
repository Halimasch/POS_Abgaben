using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AllerNeuesteKonsolenAnwendung
{
    public class DAL
    { 
        // diese 3 Member sind notwendig um eine XML-Datei zu erstellen 
        private XmlDocument _Doc;
        private XmlElement _Root;
        private string _Path;

        public DAL()
        {
            _Doc = new XmlDocument();
            _Doc.LoadXml("<?xml version='1.0'?>" + "<Lotterie/>");
            _Path = @"C:\dev\POS_Abgaben\AllerNeuesteKonsolenAnwendung\";
        }

        // holt sich vom DOM das Root-Node und speichert es in der Membervariable _Root
        public void GenerateNewDOM()
        {
            _Root = _Doc.DocumentElement;
        }

        public void SaveDOM()
        {
            _Doc.Save(_Path + "Lotterie.xml");
        }

        public void RegisterPlayer(string vn, string nn, int plz, string ort)
        {
            XmlNode nodeSpieler = _Doc.CreateElement("Spieler");
            // nach dem erstellen der Node muss es an Root angehängt werden - .AppendChild
            _Root.AppendChild(nodeSpieler);
            nodeSpieler.InnerText = nn;

            // Xml-Attribute erstellen und anschließend die Übergabeparamter an den InnerText übergeben
            XmlAttribute wohnort = _Doc.CreateAttribute("Ort");
            XmlAttribute postLZ = _Doc.CreateAttribute("PLZ");
            XmlAttribute vorname = _Doc.CreateAttribute("Vorname");
            nodeSpieler.Attributes.Append(wohnort);
            nodeSpieler.Attributes.Append(postLZ);
            nodeSpieler.Attributes.Append(vorname);
            wohnort.InnerText = ort; 
            postLZ.InnerText = plz.ToString();
            vorname.InnerText = vn;
        }

        public void StoreTipps(string vn, string nn, Lotterie tipps)
        {
            XmlNodeList nodeList = _Doc.GetElementsByTagName("Spieler");

            foreach(XmlNode node in nodeList)
            {
                if(node.InnerText == nn && node.Attributes.GetNamedItem("Vorname").Value == vn)
                {
                    // Um jetz Nodes zu Spieler (Tipps) hinzuzufügen muss folgendes gemacht werden:
                    // 1. XmlNode "Tipp" erstellen
                    // 2. Anhängen an Node Spieler mithilfe von .AppendChild
                    XmlNode nodeTipps = _Doc.CreateElement("Tipps");
                    node.AppendChild(nodeTipps);
                    
                    foreach(int i in tipps.GetTipps())
                    {
                        // für jede Zahl in der Liste mach folgendes:
                        // 1. Erstelle XmlNode ("Tipp") mit .CreateElement
                        // 2. Anschließend schreibe die Zahl als InnerText hinein
                        // 3. tipp and nodeTipps anhängen
                        XmlNode tipp = _Doc.CreateElement("Tipp");
                        tipp.InnerText = i.ToString();
                        nodeTipps.AppendChild(tipp);

                    }
                }
            }
        }

        public void DeleteAllPlayers()
        {
            XmlNodeList list = _Doc.GetElementsByTagName("Spieler");

            foreach(XmlNode node in list)
            {
                node.RemoveAll();
            }
        }

    }
}
