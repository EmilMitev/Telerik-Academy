using System;
using System.Text;
using System.Linq;

/*  Problem 10. Unicode characters
    Write a program that converts a string to a sequence of C# Unicode character literals.
    Use format strings.
 */

class UnicodeCharacters
{
    static void Main()
    {
        string text = "Hi!";

        Console.WriteLine("\nResult -> {0}\n", text.Aggregate(string.Empty, (current, t) => current + string.Format(@"\n{0:X4}", (int)t)));

    }
}