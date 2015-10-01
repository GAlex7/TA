namespace _02.extracts_all_different_artists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;

    class DOMParser
    {
        public static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../01. XML file representing catalogue/catalog.xml");
            Console.WriteLine("Loaded XML document:");
            Console.WriteLine(doc.OuterXml);
            Console.WriteLine();
        }
    }
}