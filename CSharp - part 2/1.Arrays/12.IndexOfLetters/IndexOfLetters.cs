using System;

/*  Problem 12. Index of letters
    Write a program that creates an array containing all letters from the alphabet (A-Z).
    Read a word from the console and print the index of each of its letters in the array.
 */

class IndexOfLetters
{
    static void Main()
    {
        char[] letters = new char[26];

        int asciiCodOfLetter = 65;

        for (int i = 0; i < letters.Length; i++)
        {
            letters[i] = (char)asciiCodOfLetter;
            ++asciiCodOfLetter;
        }

        Console.WriteLine("This is your help:");

        for (int i = 0; i < letters.Length; i++)
        {
            Console.WriteLine("{0} - {1}", i, letters[i]);
        }

        Console.Write("Enter your word: ");
        string word = Console.ReadLine();
        word = word.ToUpper();
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < letters.Length; j++)
            {
                if (word[i] == letters[j])
                {
                    Console.Write("{0}, ", j);
                }
            }
        }
        Console.WriteLine();
    }
}