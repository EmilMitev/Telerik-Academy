namespace Processing_XML_in.NET
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;

    public class Task10
    {
        private const string RootDirectory = @"C:\Users\Mitev\Documents\GitHub\TelerikAcademy\Database";

        public static void GenerateXmlDirectoryTree()
        {
            var rootDir = new DirectoryInfo(RootDirectory);
            var xmlDirTree = GenerateXmlDirectoryTree(rootDir);
            var xDoc = new XDocument(xmlDirTree);
            xDoc.Save("../../task10directory.xml");

            Console.WriteLine("\tDONE!!! Check file!");
        }

        private static XElement GenerateXmlDirectoryTree(DirectoryInfo rootDir)
        {
            var dirsXml = new XElement("root");
            var subtreeXml = GenerateXmlDirectoryTreeRecursively(rootDir);
            dirsXml.Add(subtreeXml);

            return dirsXml;
        }

        private static XElement GenerateXmlDirectoryTreeRecursively(DirectoryInfo rootDir)
        {
            var dirXml = new XElement("dir", new XAttribute("name", rootDir.Name));

            foreach (var file in rootDir.GetFiles())
            {
                var fileXml = new XElement("file", new XAttribute("name", file.Name));
                dirXml.Add(fileXml);
            }

            foreach (var directory in rootDir.GetDirectories())
            {
                dirXml.Add(GenerateXmlDirectoryTreeRecursively(directory));
            }

            return dirXml;
        }
    }
}