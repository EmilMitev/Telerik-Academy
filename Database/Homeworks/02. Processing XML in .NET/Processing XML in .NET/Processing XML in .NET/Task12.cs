namespace Processing_XML_in.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;

    public class Task12
    {
        public static void ShowAllAlbumWithPriceBeforeFiveYears(int year)
        {
            var xmlDoc = XDocument.Load("../../catalogue.xml");
            var albums =
                from album in xmlDoc.Descendants("album")
                where int.Parse(album.Element("year").Value) < (year - 5)
                select new
                {
                    Name = album.Element("name").Value,
                    Price = album.Element("price").Value
                };

            foreach (var album in albums)
            {
                Console.WriteLine("\t{0} ---> {1}", album.Name, album.Price);
            }
        }
    }
}
