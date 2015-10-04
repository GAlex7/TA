namespace TraverseDirectoryToXmlFile
{
    using System.IO;
    using System.Xml.Linq;

    internal class TraverseDirectory
    {
        public static void Main()
        {
            GenerateXmlDirectoryTree();
            System.Console.WriteLine("Look at directory.xml");
        }

        private static void GenerateXmlDirectoryTree()
        {
            var rootDir = new DirectoryInfo("../..");
            var xmlDirTree = GenerateXmlDirectoryTree(rootDir);
            var xDoc = new XDocument(xmlDirTree);
            xDoc.Save("../../directory.xml");
        }

        private static XElement GenerateXmlDirectoryTree(DirectoryInfo rootDir)
        {
            var dirsXml = new XElement("root");
            var subtreeXml = GenerateDirectoryTree(rootDir);
            dirsXml.Add(subtreeXml);

            return dirsXml;
        }

        private static XElement GenerateDirectoryTree(DirectoryInfo rootDir)
        {
            var dirXml = new XElement("dir", new XAttribute("name", rootDir.Name));

            foreach (var file in rootDir.GetFiles())
            {
                var fileXml = new XElement("file", new XAttribute("name", file.Name));
                dirXml.Add(fileXml);
            }

            foreach (var directory in rootDir.GetDirectories())
            {
                dirXml.Add(GenerateDirectoryTree(directory));
            }

            return dirXml;
        }
    }
}