namespace _03.XPathExtract
{
    using System;
    using System.Collections.Generic;
    using System.Xml;
    using System.Xml.XPath;

    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalogue.xml");

            var uniqueArtists = XPathExtract(doc);

            foreach (var artist in uniqueArtists)
            {
                Console.WriteLine("{0} - {1} albums", artist.Key, artist.Value);
            }
        }

        static Dictionary<string, int> XPathExtract(XmlDocument doc)
        {
            string pathQuery = "albums/album/artist";

            var artistsAndAlbums = new Dictionary<string, int>();
            XmlNodeList artists = doc.SelectNodes(pathQuery);

            foreach (XmlElement artist in artists)
            {
                var artistName = artist.InnerText;

                if (!artistsAndAlbums.ContainsKey(artistName))
                {
                    artistsAndAlbums.Add(artistName, 1);
                }
                else
                {
                    artistsAndAlbums[artistName] += 1;
                }
            }
            return artistsAndAlbums;
        }
    }
}
