namespace _05.ExtractsAllSongTitles
{
    using System;
    using System.Xml;

    internal class ExtractsAllSongTitles
    {
        public static void Main(string[] args)
        {
            using (XmlReader reader = new XmlTextReader("../../../01.XmlCatalog/catalog.xml"))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "title")
                    {
                        Console.WriteLine(reader.ReadElementContentAsString());
                    }
                }
            }
        }
    }
}
