using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Konsole_11_10
{
    public class DAL
    {
        private XmlDocument m_Doc;
        private XmlElement m_Root;
        private string m_Pfad;
        
        public DAL()
        {
            m_Pfad = @"C:\Dev\POS-Ingenium\Konsole_11_10\";
            m_Doc = new XmlDocument();
            m_Doc.LoadXml("<?xml version='1.0'?> <Familien/>");
            m_Root = m_Doc.DocumentElement;
        }

        public void AddFamilyName(string famName)
        {
            XmlElement fam = m_Doc.CreateElement("Familie");
            m_Root.AppendChild(fam);

            XmlAttribute att = m_Doc.CreateAttribute("Name");
            att.Value = famName;
            fam.Attributes.Append(att);
        }

        public void AddFammly(string famName, string Vater, string Mutter)
        {
            XmlNodeList fL = m_Doc.GetElementsByTagName("Familie");

            foreach(XmlNode node in fL)
            {
                if(node.Attributes.GetNamedItem("Name").Value == famName)
                {
                    XmlElement elemVater = m_Doc.CreateElement("Vater");
                    elemVater.InnerText = Vater;
                    node.AppendChild(elemVater);

                    XmlElement elemMutter = m_Doc.CreateElement("Mutter");
                    elemMutter.InnerText = Mutter;
                    node.AppendChild(elemMutter);
                }
            }
        }

        public void SpeicherDOM(string filename)
        {
            m_Doc.Save(m_Pfad + filename);
        }
    }
}
