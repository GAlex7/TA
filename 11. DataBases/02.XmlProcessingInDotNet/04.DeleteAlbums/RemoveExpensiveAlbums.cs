namespace DeleteAlbums
{
    using System;
    using System.Xml;

    internal class RemoveExpensiveAlbums
    {
        public static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../01.XmlCatalog/catalog.xml");
            var root = doc.DocumentElement;

            DeleteAlbumsWithPrice(root, 20.0);
            doc.Save("../../../01.XmlCatalog/newCatalog.xml");
            Console.WriteLine("new catalogue saved as newCatalogue.xml");
        }

        private static void DeleteAlbumsWithPrice(XmlElement root, double maxPrice)
        {
            foreach (XmlElement album in root.ChildNodes[0].ChildNodes)
            {
                var xmlPrice = album["price"].InnerText;
                var price = double.Parse(xmlPrice);

                if (price > maxPrice)
                {
                    root.ChildNodes[0].RemoveChild(album);
                }
            }
        }
    }
}
