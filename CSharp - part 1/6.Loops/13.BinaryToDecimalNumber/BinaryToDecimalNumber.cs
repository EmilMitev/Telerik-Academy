using System;

/*  Problem 13. Binary to Decimal Number
    Using loops write a program that converts a binary integer number to its decimal form.
    The input is entered as string. The output should be a variable of type long.
    Do not use the built-in .NET functionality.
 */

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter your binnary number: ");
        string binnaryNumber = Console.ReadLine();
        long result = 0;
        char digit;
        int power = 0;

        for (int i = binnaryNumber.Length-1; i >= 0; i--)
        {
            digit = binnaryNumber[i];
            if (digit == '1')
            {
                result += (long)Math.Pow(2, power);
            }
            ++power;
        }
        Console.WriteLine("Result is: " + result);
    }
}