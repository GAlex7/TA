namespace ExtractsAllSongTitlesByLinq
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    internal class Program
    {
        public static void Main(string[] args)
        {
            var doc = XDocument.Load("../../../01.XmlCatalog/catalog.xml");
            var albums = doc.Element("catalog")
                .Elements("albums")
                .Elements("album");

            var titles = from title in albums.Descendants("title") select title.Value;

            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }
        }
    }
}
