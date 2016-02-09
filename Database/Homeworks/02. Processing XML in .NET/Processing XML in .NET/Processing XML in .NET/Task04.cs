namespace Processing_XML_in.NET
{
    using System;
    using System.Xml;

    public class Task04
    {
        public static void DeleteChild(int price)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../Catalogue.xml");

            XmlNode rootNode = xmlDoc.DocumentElement;

            Console.WriteLine("\tChild nodes before deleting: {0}", rootNode.ChildNodes.Count);
            foreach (XmlNode node in rootNode.ChildNodes)
            {
                var albumPrice = node["price"].InnerText;

                if (double.Parse(albumPrice) > price)
                {
                    rootNode.RemoveChild(node);
                    Console.WriteLine("\t\tDeleted");
                }
            }

            Console.WriteLine("\tChild nodes after deleting: {0}", rootNode.ChildNodes.Count);
        }
    }
}
