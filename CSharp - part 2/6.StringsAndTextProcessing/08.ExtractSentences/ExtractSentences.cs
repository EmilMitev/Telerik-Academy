using System;

/*  Problem 8. Extract sentences

    Write a program that extracts from a given text all sentences containing given word.
    Example:
    The word is: in
    The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
    The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
    Consider that the sentences are separated by . and the words – by non-letter symbols.
 */

class ExtractSentences
{
    static void Main()
    {
        string sentence = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

        string[] str = sentence.Split('.');
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i].Contains(" in "))
            {
                Console.Write(str[i].Trim() + ".");
            }
        }
        Console.WriteLine();
    }
}