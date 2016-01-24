namespace _02.DOMParserExtract
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalogue.xml");

            var uniqueArtists = DomParserExtract(doc);

            foreach (var artist in uniqueArtists)
            {
                Console.WriteLine("{0} - {1} albums", artist.Key, artist.Value);
            }
        }

        static Dictionary<string, int> DomParserExtract(XmlDocument doc)
        {
            XmlElement rootNode = doc.DocumentElement;

            var artistsAndAlbums = new Dictionary<string, int>();
            var artists = rootNode.GetElementsByTagName("artist");

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