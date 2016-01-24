namespace _12.ExtractRecentAlbumsLINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string docPath = "../../../catalogue.xml";

            int yearsBack = 5;

            var albums = XPathExtractRecent(docPath, yearsBack);


            foreach (var item in albums)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Value);
            }
        }

        private static Dictionary<string, string> XPathExtractRecent(string docPath, int yearsBack)
        {
            int year = DateTime.Today.Year - yearsBack;
            XDocument xmlDoc = XDocument.Load(docPath);

            var albums = xmlDoc.Descendants("album")
                .Where(a => (int)a.Element("year") > year)
                //.Select(a => new { Name = a.Element("name").Value, Year = a.Element("year").Value })
                //.ToDictionary(a => a.Name, a => a.Year);
                .ToDictionary(a => a.Element("name").Value, a => a.Element("year").Value);

            return albums;
        }
    }
}
