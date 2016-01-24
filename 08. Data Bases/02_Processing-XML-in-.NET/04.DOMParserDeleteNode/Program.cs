namespace _04.DOMParserDeleteNode
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    class Program
    {
        static void Main(string[] args)
        {
            string oldDoc = "../../../catalogue.xml";
            string newDoc = "../../catalogueNew.xml";

            XmlDocument doc = new XmlDocument();
            doc.Load(oldDoc);

            XmlElement rootNode = doc.DocumentElement;

            foreach (XmlElement node in rootNode.ChildNodes)
            {
                Console.WriteLine("{0} - {1}", node["name"].InnerText, node["price"].InnerText);
            }

            DeleteNodes(rootNode);

            doc.Save(newDoc);

            Console.WriteLine(new string('-', 40));

            foreach (XmlElement node in rootNode.ChildNodes)
            {
                Console.WriteLine("{0} - {1}", node["name"].InnerText, node["price"].InnerText);
            }
        }

        static void DeleteNodes(XmlElement rootNode)
        {
            var removedNodeList = new List<XmlElement>();

            foreach (XmlElement node in rootNode.ChildNodes)
            {
                var price = double.Parse(node["price"].InnerText, System.Globalization.CultureInfo.InvariantCulture);
                if (price > 20)
                {
                    removedNodeList.Add(node);
                }
            }

            foreach (var node in removedNodeList)
            {
                rootNode.RemoveChild(node);
            }
        }
    }
}
