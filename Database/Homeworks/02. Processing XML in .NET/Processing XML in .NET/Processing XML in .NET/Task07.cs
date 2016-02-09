namespace Processing_XML_in.NET
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml;

    public class Task07
    {
        public static void ConvetTextToXml()
        {
            string[] lines;
            const int NumberOfTagsForEachPerson = 3;
            using (var writer = new XmlTextWriter("../../toXml.xml", Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                using (StreamReader reader = new StreamReader("../../fromText.txt"))
                {
                    lines = reader.ReadToEnd().Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                    writer.WriteStartDocument();
                    writer.WriteStartElement("Persons");

                    for (int i = 0; i < lines.Length; i += NumberOfTagsForEachPerson)
                    {
                        writer.WriteStartElement("Person");
                        writer.WriteElementString("name", lines[i]);
                        writer.WriteElementString("adress", lines[i + 1]);
                        writer.WriteElementString("telephone", lines[i + 2]);
                        writer.WriteEndElement();
                    }

                    writer.WriteEndElement();
                }
            }

            Console.WriteLine("\tDONE!!! Check file!");
        }
    }
}
