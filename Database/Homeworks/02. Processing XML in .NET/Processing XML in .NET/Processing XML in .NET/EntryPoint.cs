namespace Processing_XML_in.NET
{
    using System;

    public class EntryPoint
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Task 2 and 3");
            Console.WriteLine(" - With Dom Parser:");
            Task02.ExtractsAllDifferentArtists();

            Console.WriteLine();
            Console.WriteLine(" - With XPath:");
            Task03.ExtractsAllDifferentArtists();

            Console.WriteLine();
            Console.WriteLine("Task 4");
            Console.WriteLine(" - With Dom Parser:");
            Task04.DeleteChild(20);

            Console.WriteLine();
            Console.WriteLine("Task 5 and 6");
            Console.WriteLine(" - With XmlReader:");
            Task05.ExtractAllSongTitles();

            Console.WriteLine();
            Console.WriteLine(" - XDocument and LINQ query:");
            Task06.ExtractAllSongTitles();

            Console.WriteLine();
            Console.WriteLine("Task 7");
            Task07.ConvetTextToXml();

            Console.WriteLine();
            Console.WriteLine("Task 8");
            Task08.CreateAnotherXmlFileFromExisting();

            Console.WriteLine();
            Console.WriteLine("Task 9");
            Task09.GenerateXmlDirectoryTree();

            Console.WriteLine();
            Console.WriteLine("Task 10");
            Task10.GenerateXmlDirectoryTree();

            Console.WriteLine();
            Console.WriteLine("Task 11");
            Task11.ShowAllAlbumWithPriceBeforeFiveYears(2015);

            Console.WriteLine();
            Console.WriteLine("Task 12");
            Task12.ShowAllAlbumWithPriceBeforeFiveYears(2015);

            Console.WriteLine();
            Console.WriteLine("Task 13 and 14");
            Task13_14.TransformFromXmlToHtml();
        }
    }
}
