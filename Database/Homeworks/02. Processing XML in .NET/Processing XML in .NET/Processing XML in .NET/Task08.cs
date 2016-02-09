namespace Processing_XML_in.NET
{
    using System.Text;
    using System.Xml;

    public class Task08
    {
        public static void CreateAnotherXmlFileFromExisting()
        {
            using (var writer = new XmlTextWriter("../../Album.xml", Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                using (XmlReader reader = XmlReader.Create("../../Catalogue.xml"))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("albums");

                    while (reader.Read())
                    {
                        if (reader.Name == "name")
                        {
                            writer.WriteStartElement("album");
                            writer.WriteElementString("name", reader.ReadElementString());
                        }
                        else if (reader.Name == "artist")
                        {
                            writer.WriteElementString("authors", reader.ReadElementString());
                            writer.WriteEndElement();
                        }
                    }

                    writer.WriteEndElement();
                }
            }

            System.Console.WriteLine("\tDONE!!! Check file!");
        }
    }
}
