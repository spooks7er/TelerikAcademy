namespace ProcessingXML.NET
{
    using System;
    using System.Xml.Linq;
    using System.Xml.Schema;

    class Program
    {   // Validating xml
        static void Main(string[] args)
        {
            var schema = new XmlSchemaSet();
            schema.Add(string.Empty, "../../../catalogue.xsd");

            XDocument doc = XDocument.Load("../../../catalogue.xml");

            XDocument docInvalid = XDocument.Load("../../catalogueInvalid.xml");

            doc.Validate(schema, (obj, ev) =>
            {
                Console.WriteLine(ev.Message);
            });

            docInvalid.Validate(schema, (obj, ev) =>
            {
                Console.WriteLine(ev.Message);
            });
        }
    }
}
