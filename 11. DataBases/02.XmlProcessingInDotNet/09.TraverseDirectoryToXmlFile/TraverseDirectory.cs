namespace TraverseDirectoryToXmlFile
{
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml;

    internal class TraverseDirectory
    {
        private const string RootDirectory = "../..";

        public static void Main()
        {
            GenerateXmlDirectoryTree();
        }

        private static void GenerateXmlDirectoryTree()
        {
            string fileName = "../../directory.xml";
            var encoding = Encoding.GetEncoding("utf-8");
            var rootDirectory = new DirectoryInfo(RootDirectory);
            using (var writer = new XmlTextWriter(fileName, encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = ' ';
                writer.Indentation = 4;

                writer.WriteStartDocument();
                writer.WriteStartElement("root");

                TraverseDir(writer, rootDirectory);

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        private static void TraverseDir(XmlTextWriter writer, DirectoryInfo rootDirectory)
        {
            if (!rootDirectory.GetFiles().Any() && !rootDirectory.GetDirectories().Any())
            {
                return;
            }

            writer.WriteStartElement("dir", rootDirectory.Name);

            foreach (var file in rootDirectory.GetFiles())
            {
                writer.WriteElementString("file", file.Name);
            }

            foreach (var directory in rootDirectory.GetDirectories())
            {
                TraverseDir(writer, directory);
            }

            writer.WriteEndElement();
        }
    }
}