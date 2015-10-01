namespace ExtractsAllArtists
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class DOMParser
    {
        public static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../01. XML file representing catalogue/catalog.xml");
            var root = doc.DocumentElement;

            foreach (var pair in GetArtists(root))
            {
                Console.WriteLine("{0} - {1} album(s)", pair.Key, pair.Value);
            }
        }

        private static Dictionary<string, int> GetArtists(XmlElement root)
        {
            var artistsAndAlbums = new Dictionary<string, int>();
            var artists = root.GetElementsByTagName("artist");

            foreach (XmlElement artist in artists)
            {
                var artistName = artist.InnerText;

                if (artistsAndAlbums.ContainsKey(artistName))
                {
                    artistsAndAlbums[artistName] += 1;
                }
                else
                {
                    artistsAndAlbums.Add(artistName, 1);
                }
            }

            return artistsAndAlbums;
        }
    }
}