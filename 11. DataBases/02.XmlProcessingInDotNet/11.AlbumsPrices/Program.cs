namespace _11.AlbumsPrices
{
    using System;
    using System.Xml;

    internal class Program
    {
        public static void Main(string[] args)
        {
            int currentYear = 2015;
            string xPathQuery = "/catalog/albums/album[year]";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load("../../../01.XmlCatalog/catalog.xml");

            var albumsList = xmlDoc.SelectNodes(xPathQuery);
            foreach (XmlNode albumNode in albumsList)
            {
                var year = int.Parse(albumNode.SelectSingleNode("year").InnerText);
                if (year <= currentYear - 5)
                {
                    var albumName = albumNode.SelectSingleNode("name").InnerText;
                    var albumPrice = albumNode.SelectSingleNode("price").InnerText;
                    Console.WriteLine("{0}: ${1}", albumName, albumPrice);
                }
            }
        }
    }
}
