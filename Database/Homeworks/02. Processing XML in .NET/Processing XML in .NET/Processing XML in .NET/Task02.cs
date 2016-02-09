namespace Processing_XML_in.NET
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class Task02
    {
        public static void ExtractsAllDifferentArtists()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../Catalogue.xml");

            XmlNode rootNode = xmlDoc.DocumentElement;

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                var artistName = node["artist"].InnerText;

                if (dictionary.ContainsKey(artistName))
                {
                    dictionary[artistName]++;
                }
                else
                {
                    dictionary.Add(artistName, 1);
                }
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine("\tArtist name: {0} albums: {1}", item.Key, item.Value);
            }
        }
    }
}
