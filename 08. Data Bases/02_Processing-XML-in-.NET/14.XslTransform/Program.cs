namespace _14.XslTransform
{
    using System.Xml.Xsl;

    class Program
    {
        static void Main(string[] args)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("../../../catalogue.xslt");
            xslt.Transform("../../../catalogue.xml", "../../catalogue.html");
        }
    }
}
