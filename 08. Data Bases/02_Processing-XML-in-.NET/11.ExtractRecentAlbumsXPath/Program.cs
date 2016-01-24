namespace _11.ExtractRecentAlbumsXPath
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

            int yearsBack = 5;

            var albums = XPathExtractRecent(doc, yearsBack);

            foreach (var album in albums)
            {
                Console.WriteLine(album);
            }
        }

        static List<string> XPathExtractRecent(XmlDocument doc, int yearsBack)
        {
            int year = DateTime.Today.Year - yearsBack;
            string pathQuery = string.Format("albums/album[year>{0}]/name", year);

            var albums = new List<string>();
            XmlNodeList albumsXml = doc.SelectNodes(pathQuery);

            foreach (XmlElement album in albumsXml)
            {
                var albumName = album.InnerText;

                albums.Add(albumName);
            }
            return albums;
        }
    }
}
