namespace Processing_XML_in.NET
{
    using System;
    using System.Xml;

    public class Task11
    {
        public static void ShowAllAlbumWithPriceBeforeFiveYears(int yearNow)
        {
            const string xPathQuery = "/albums/album[year]";

            var xmlDoc = new XmlDocument();
            xmlDoc.Load("../../catalogue.xml");

            var albumsList = xmlDoc.SelectNodes(xPathQuery);

            foreach (XmlNode albumNode in albumsList)
            {
                var year = int.Parse(albumNode.SelectSingleNode("year").InnerText);

                if (year < yearNow - 5)
                {
                    var albumName = albumNode.SelectSingleNode("name").InnerText;
                    var albumPrice = albumNode.SelectSingleNode("price").InnerText;

                    Console.WriteLine("\tAlbum {0} ---> {1}$", albumName, albumPrice);
                }
            }
        }
    }
}
