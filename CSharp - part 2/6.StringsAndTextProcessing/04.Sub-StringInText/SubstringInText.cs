using System;

/*  Problem 4. Sub-string in text

    Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
    Example
    The target sub-string is in
    The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. 
        So we are drinking all the day. We will move out of it in 5 days.
    The result is: 9
 */

class SubstringInText
{
    static void Main()
    {
        string sentence = @"We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. 
                            So we are drinking all the day. We will move out of it in 5 days.";

        int countWords = 0;
        int index = 0;
        while (true)
        {
            index = sentence.ToLower().IndexOf("in", index);
            if (index != -1)
            {
                ++countWords;
            }
            else
            {
                break;
            }
            ++index;
        }
        Console.WriteLine("The sub-string \"in\" is contained in the text {0} times.", countWords);
    }
}