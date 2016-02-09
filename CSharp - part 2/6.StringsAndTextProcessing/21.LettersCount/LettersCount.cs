using System;
using System.Collections.Generic;

/*  Problem 21. Letters count
    Write a program that reads a string from the console and prints all different letters in the 
    string along with information how many times each letter is found.
 */

class LettersCount
{
    static void Main()
    {
        //string text = Console.ReadLine();
        string text = "aaabaaassasaa";
        Dictionary<char, int> dic = new Dictionary<char, int>();

        int i = 0;
        int count = 0;

        while (true)
        {
            char ch = text[i];
            if (!dic.ContainsKey(ch))
            {
                for (int j = 0; j < text.Length; j++)
                {
                    if (ch == text[j])
                    {
                        ++count;
                    }
                }
                dic.Add(ch, count);
            }
            count = 0;
            ++i;
            if (i == text.Length - 1)
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