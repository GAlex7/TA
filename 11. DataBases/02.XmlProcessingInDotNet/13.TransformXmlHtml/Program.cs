namespace TransformXmlHtml
{
    using System;
    using System.Xml.Xsl;

    internal class Program
    {
        public static void Main(string[] args)
        {
            var xslt = new XslCompiledTransform();
            xslt.Load("../../catalog.xsl");
            xslt.Transform("../../../01.XmlCatalog/catalog.xml", "../../catalog.html");
            Console.WriteLine("Now you can see catalog.html");
        }
    }
}
