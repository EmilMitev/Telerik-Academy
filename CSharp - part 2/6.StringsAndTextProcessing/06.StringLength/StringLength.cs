using System;
using System.Text;

/*  Problem 6. String length
    Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, 
    the rest of the characters should be filled with *.
    Print the result string into the console.
 */

class StringLength
{
    static void Main()
    {
        StringBuilder builder = new StringBuilder(20);

        for (int i = 0; i < 20; i++)
        {
            var key = Console.ReadKey();

            if (key.Key == ConsoleKey.Enter)
            {
                if (i<20)
                {
                    for (int j = i; j < 20; j++)
                    {
                        builder.Append("*");
                    }
                }
                break;
            }
            else
            {
                builder.Append(key.KeyChar);
            }
        }
        Console.WriteLine();
        Console.WriteLine(builder.ToString());
    }
}