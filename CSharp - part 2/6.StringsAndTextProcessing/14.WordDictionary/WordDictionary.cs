using System;
using System.Collections.Generic;

/*  Problem 14. Word dictionary
    A dictionary is stored as a sequence of text lines containing words and their explanations.
    Write a program that enters a word and translates it by using the dictionary.
 */

class WordDictionary
{
    static void Main()
    {
        Dictionary<string, string> dic = new Dictionary<string, string>();

        dic.Add(".NET", "platform for applications from Microsoft");
        dic.Add("CLR", "managed execution environment for .NET");
        dic.Add("namespace", "hierarchical organization of classes");

        string word = Console.ReadLine();
        Console.WriteLine(dic[word]);
    }
}