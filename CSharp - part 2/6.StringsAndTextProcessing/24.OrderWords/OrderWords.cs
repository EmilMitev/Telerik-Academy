using System;

/*  Problem 24. Order words
    Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
 */

class OrderWords
{
    static void Main()
    {
        //string text = Console.ReadLine();
        string text = "Ti koito proverqvash si super";
        string[] words = text.Split(' ');
        Array.Sort(words);
        foreach (var item in words)
        {
            Console.WriteLine(item);
        }

    }
}