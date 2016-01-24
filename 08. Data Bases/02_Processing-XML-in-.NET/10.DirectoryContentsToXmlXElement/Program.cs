using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.DirectoryContentsToXmlXElement
{
    using System;
    using System.IO;
    using System.Xml;
    using System.Xml.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var desktop = Traverse(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            desktop.Save("../../dir.xml");
            Console.WriteLine("result saved as dir.xml");
        }

        public static XElement Traverse(string dir)
        {
            var element = new XElement("dir", new XAttribute("path", dir));

            foreach (var directory in Directory.GetDirectories(dir))
            {
                element.Add(Traverse(directory));
            }

            foreach (var file in Directory.GetFiles(dir))
            {
                Console.WriteLine(file);
                element.Add(new XElement("file",
                    new XAttribute("name", Path.GetFileNameWithoutExtension(file)),
                    new XAttribute("ext", Path.GetExtension(file))));
            }

            return element;
        }
    }
}