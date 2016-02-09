namespace Processing_XML_in.NET
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;

    public class Task09
    {
        private const string RootDirectory = @"C:\Users\Mitev\Documents\GitHub\TelerikAcademy\Database";

        public static void GenerateXmlDirectoryTree()
        {
            const string fileName = "../../task09directory.xml";
            var encoding = Encoding.GetEncoding("utf-8");
            var rootDirectory = new DirectoryInfo(RootDirectory);
            using (var writer = new XmlTextWriter(fileName, encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = ' ';
                writer.Indentation = 2;

                writer.WriteStartDocument();
                writer.WriteStartElement("root");
                TraverseRootDirectoryRecursively(writer, rootDirectory);
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }

            Console.WriteLine("\tDONE!!! Check file!");
        }

        private static void TraverseRootDirectoryRecursively(XmlTextWriter writer, DirectoryInfo rootDirectory)
        {
            if (!rootDirectory.GetFiles().Any() && !rootDirectory.GetDirectories().Any())
            {
                return;
            }

            writer.WriteStartElement("dir");
            writer.WriteStartAttribute("name", rootDirectory.Name);

            foreach (var file in rootDirectory.GetFiles())
            {
                writer.WriteStartElement("file");
                writer.WriteStartAttribute("name", file.Name);
                writer.WriteEndElement();
            }

            foreach (var directory in rootDirectory.GetDirectories())
            {
                TraverseRootDirectoryRecursively(writer, directory);
            }

            writer.WriteEndElement();
        }
    }
}