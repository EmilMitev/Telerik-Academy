namespace _03.WordsCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Startup
    {
        private static string filePath = "../../Files/words.txt";

        public static void Main() 
        {
            //var fileText = File.ReadAllText(filePath);

            var fileText = "This is the TEXT. Text, text, text – THIS TEXT! Is this the text?";

            var words = fileText.Split(new char[] { ',', ' ', '.', '!', '?', '–', '-' }, StringSplitOptions.RemoveEmptyEntries);

            var wordsDictionary = new Dictionary<string, int>();

            foreach (var item in words)
            {
                var wordToLower = item.ToLower();

                if (!wordsDictionary.ContainsKey(wordToLower))
                {
                    wordsDictionary[wordToLower] = 1;
                }
                else
                {
                    wordsDictionary[wordToLower]++;
                }
            }

            wordsDictionary.OrderBy(x => x.Value)
                .ToList()
                .ForEach(x => { Console.WriteLine(x.Key + " -> " + x.Value + " occurences."); });
        }
    }
}
