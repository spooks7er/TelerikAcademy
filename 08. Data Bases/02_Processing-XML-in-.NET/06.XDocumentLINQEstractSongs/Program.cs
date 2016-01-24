namespace _06.XDocumentLINQEstractSongs
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

            var songNames = ExtractSongs(docPath);

            foreach (var song in songNames)
            {
                Console.WriteLine(song);
            }
        }

        private static IEnumerable<string> ExtractSongs(string docPath)
        {
            XDocument xmlDoc = XDocument.Load(docPath);

            return
            from song in xmlDoc.Descendants("title")
            select song.Value; 
        }
    }
}
