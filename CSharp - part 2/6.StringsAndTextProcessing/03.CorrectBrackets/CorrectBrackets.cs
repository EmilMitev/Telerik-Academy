using System;
using System.Collections.Generic;

/*  Problem 3. Correct brackets
    Write a program to check if in a given expression the brackets are put correctly.
    Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
 */

class CorrectBrackets
{
    static void Main()
    {
        string correctExpression = ")((a+b))/5-d)";
        string incorrestExpression = ")(a+b))";

        List<int> countOpenBracket = new List<int>();
        List<int> countCloseBracket = new List<int>();

        int indexOpenBracket = 0;
        int indexCloseBracket = 0;

        while (true)
        {
            indexOpenBracket = correctExpression.IndexOf("(", indexOpenBracket);
            indexCloseBracket = correctExpression.IndexOf(")", indexCloseBracket);

            if (indexOpenBracket != -1 )
            {
                countOpenBracket.Add(indexOpenBracket);
            }

            if(indexCloseBracket != -1)
            {
                countCloseBracket.Add(indexCloseBracket);
            }

            if (indexCloseBracket==-1&&indexOpenBracket==-1)
            {
                break;
            }

            ++indexCloseBracket;
            ++indexOpenBracket;

        }

        if (countCloseBracket.Count != countOpenBracket.Count)
        {
            Console.WriteLine("Incorrect expression!!!");
        }
        else
        {
            for (int i = 0; i < countOpenBracket.Count; i++)
            {
                if (countCloseBracket[i]< countOpenBracket[i])
                {
                    Console.WriteLine("Incorrect expression!!!");
                    break;
                }
                else
                {
                    if (i==countOpenBracket.Count-1)
                    {
                        Console.WriteLine("Correct expression");
                    }
                }
            }
        }

    }
}