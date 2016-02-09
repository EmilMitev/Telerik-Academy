using System;
using System.Collections.Generic;

/*  Problem 23. Series of letters
    Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
 */

class SeriesOfLetters
{
    static void Main()
    {
        //string text = Console.ReadLine();
        string text = "aaaaabbbbbcdddeeeedssaa";
        List<char> list = new List<char>();
        int index = 0;

        list.Add(text[index]);

        while (index != text.Length - 2)
        {
            if (!(text[index] == text[index + 1]))
            {
                list.Add(text[index + 1]);
            }
            ++index;
        }
        foreach (var item in list)
        {
            Console.Write(item);
        }
    }
}
