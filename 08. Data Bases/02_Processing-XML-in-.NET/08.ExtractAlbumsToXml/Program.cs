namespace _08.ExtractAlbumsToXml
{
    using System;
    using System.Text;
    using System.Xml;

    class Program
    {
        static void Main(string[] args)
        {
            string docPath = "../../../catalogue.xml";
            string newDocPath = "../../albumInfo.xml";

            ExtractAlbumInfo(docPath, newDocPath);
        }

        public static void ExtractAlbumInfo(string docPath, string newDocPath)
        {
            using (XmlTextWriter writer = new XmlTextWriter(newDocPath, Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = ' ';
                writer.Indentation = 2;

                writer.WriteStartDocument();
                writer.WriteStartElement("albums");

                using (XmlReader reader = XmlReader.Create(docPath))
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            if (reader.Name == "name")
                            {
                                writer.WriteStartElement("album");
                                writer.WriteElementString("name", reader.ReadElementString());
                            }
                            else if (reader.Name == "artist")
                            {
                                writer.WriteElementString("artist", reader.ReadElementString());
                                writer.WriteEndElement();
                            }
                        }
                    }
                }

                writer.WriteEndDocument();
            }
            string filename = newDocPath.Substring(newDocPath.LastIndexOf('/')+1);
            Console.WriteLine("albums info saved as {0}", filename);
        }
    }
}
