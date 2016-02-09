using System;

/*  Problem 14. Decimal to Binary Number
    Using loops write a program that converts an integer number to its binary representation.
    The input is entered as long. The output should be a variable of type string.
    Do not use the built-in .NET functionality.
 */

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Enter your number: ");
        int number = int.Parse(Console.ReadLine());
        string binnaryNumber = "";

        do
        {
            if (number % 2 == 0)
            {
                binnaryNumber += "0";
            }
            else
            {
                binnaryNumber += "1";
            }
            number /= 2;

        } while (number != 0);

        Console.Write("Binnary: ");
        for (int i = binnaryNumber.Length - 1; i >= 0; i--)
        {
            Console.Write(binnaryNumber[i]);
        }
        Console.WriteLine();
    }
}