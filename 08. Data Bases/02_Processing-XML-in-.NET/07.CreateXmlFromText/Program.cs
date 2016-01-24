namespace _07.CreateXmlFromText
{
    using System;
    using System.Xml.Linq;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            using (StreamReader reader = new StreamReader("../../contactInfo.txt"))
            {
                person.Name = reader.ReadLine();
                person.Phone = reader.ReadLine();
                person.Address = reader.ReadLine();
            }

            var personElement = new XElement("person",
                new XElement("name", person.Name),
                new XElement("phone", person.Phone),
                new XElement("address", person.Address));

            personElement.Save("../../contactInfo.xml");
            Console.WriteLine("person info saved as contactInfo.xml");
        }
    }
}
