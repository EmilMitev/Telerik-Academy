using System;
using System.Globalization;
using System.Threading;

/*  Problem 7. Sort 3 Numbers with Nested Ifs
    Write a program that enters 3 real numbers and prints them sorted in descending order.
    Use nested if statements.
    Note: Don’t use arrays and the built-in sorting functionality.
 */

class SortThreeNumbersWithNestedIfs
{
    static void Main()
    {

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("First number:");
        double firstNumber = double.Parse(Console.ReadLine().Replace(',', '.'));

        Console.Write("Second number:");
        double secondNumber = double.Parse(Console.ReadLine().Replace(',', '.'));

        Console.Write("Third number:");
        double thirdNumber = double.Parse(Console.ReadLine().Replace(',', '.'));

        if (firstNumber >= secondNumber)
        {
            if (firstNumber >= thirdNumber)
            {
                if (secondNumber >= thirdNumber)
                {
                    Console.WriteLine("Result: {0} {1} {2}", firstNumber, secondNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("Result: {0} {1} {2}", firstNumber, thirdNumber, secondNumber);
                }
            }
            else
            {
                Console.WriteLine("Result: {0} {1} {2}", thirdNumber, firstNumber, secondNumber);
            }
        }
        else if (secondNumber >= thirdNumber)
        {
            if (secondNumber >= firstNumber)
            {
                if (firstNumber >= thirdNumber)
                {
                    Console.WriteLine("Result: {0} {1} {2}", secondNumber, firstNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("Result: {0} {1} {2}", secondNumber, thirdNumber, firstNumber);
                }
            }
            else
            {
                Console.WriteLine("Result: {0} {1} {2}", firstNumber, secondNumber, thirdNumber);
            }
        }
        else
        {
            if (firstNumber>=secondNumber)
            {
                Console.WriteLine("Result: {0} {1} {2}", thirdNumber, firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("Result: {0} {1} {2}", thirdNumber, secondNumber, firstNumber);
            }
        }

    }
}