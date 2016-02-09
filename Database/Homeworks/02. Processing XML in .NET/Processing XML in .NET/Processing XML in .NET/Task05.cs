namespace Processing_XML_in.NET
{
    using System;
    using System.Xml;

    public class Task05
    {
        public static void ExtractAllSongTitles()
        {
            var artist = string.Empty;

            using (XmlReader reader = XmlReader.Create("../../Catalogue.xml"))
            {
                while (reader.Read())
                {
                    if (reader.Name == "title")
                    {
                        Console.WriteLine("\t {0}", reader.ReadElementString());
                    }
                }
            }
        }
    }
}
