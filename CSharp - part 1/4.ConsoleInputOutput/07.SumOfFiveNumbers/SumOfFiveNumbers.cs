using System;
using System.Threading;
using System.Globalization;

/*  Problem 7. Sum of 5 Numbers
    Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
 */

class SumOfFiveNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter 5 numbers (given in a single line, separated by a space): ");
        string strNumbers = Console.ReadLine();
        string[] numbers = strNumbers.Split(' ');

        double result = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            result += double.Parse(numbers[i]);
        }

        Console.WriteLine("Result = " + result);
    }
}