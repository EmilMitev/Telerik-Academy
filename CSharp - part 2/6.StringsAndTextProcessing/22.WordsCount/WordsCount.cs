using System;
using System.Collections.Generic;

/*  Problem 22. Words count
    Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.
 */

class WordsCount
{
    static void Main()
    {
        //string text = Console.ReadLine();
        string text = "aa ss fdgs fdgs r t bsz easgzc";
        string[] words = text.Split(' ');

        Dictionary<string, int> dic = new Dictionary<string, int>();

        int i = 0;
        int count = 0;

        while (true)
        {
            string word = words[i];
            if (!dic.ContainsKey(word))
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (word == words[j])
                    {
                        ++count;
                    }
                }
                dic.Add(word, count);
            }
            count = 0;
            ++i;
            if (i == words.Length)
            {
                break;
            }
        }

        foreach (var item in dic)
        {
            Console.WriteLine("{0} - {1}", item.Key, item.Value);
        }
    }
}