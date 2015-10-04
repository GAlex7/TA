namespace _12.AlbumsPricesByLinq
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    internal class Program
    {
        public static void Main(string[] args)
        {
            var xmlDoc = XDocument.Load("../../../01.XmlCatalog/catalog.xml");
            var albums =
               from album in xmlDoc.Descendants("album")
               where int.Parse(album.Element("year").Value) < 2010
               select new
               {
                   Name = album.Element("name").Value,
                   Price = album.Element("price").Value
               };

            foreach (var album in albums)
            {
                Console.WriteLine("{0}: ${1}", album.Name, album.Price);
            }
        }
    }
}
