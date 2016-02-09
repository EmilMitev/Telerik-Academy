using System;

/*  Problem 20. Palindromes
    Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
 */

class Palindromes
{
    static void Main()
    {
        string text = "This ABBA is lamal polindromes exe text";

        string[] words = text.Split(' ');
        for (int k = 0; k < words.Length; k++)
        {
            string word = words[k];
            int i = 0;
            int j = word.Length - 1;
            while (true)
            {
                if (i >= j)
                {
                    Console.WriteLine("The text it is polindrome - {0} ", word);
                    break;
                }

                if (word[i] != word[j])
                {
                    break;
                }

                ++i;
                --j;
            }
        }
    }
}