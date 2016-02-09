namespace Processing_XML_in.NET
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    public class Task06
    {
        public static void ExtractAllSongTitles()
        {
            XDocument xmlDoc = XDocument.Load("../../Catalogue.xml");
            var songs =
                from song in xmlDoc.Descendants("song")
                select new
                {
                    Title = song.Element("title").Value,
                };

            foreach (var song in songs)
            {
                Console.WriteLine("\t {0}", song.Title);
            }
        }
    }
}
