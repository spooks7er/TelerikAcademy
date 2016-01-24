namespace _05.XmlReaderExtractSongs
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

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

        public static List<string> ExtractSongs(string path)
        {
            List<string> songNames = new List<string>();

            using (XmlReader reader = XmlReader.Create(path))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "title"))
                    {
                        songNames.Add(reader.ReadElementString());
                    }
                }
            }

            return songNames;
        }
    }
}