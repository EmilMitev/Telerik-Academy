using System;
using System.Threading;
using System.Globalization;

/*  Problem 1. Sum of 3 Numbers
    Write a program that reads 3 real numbers from the console and prints their sum.
 */
public class SumOfThreeNumbers
{
    public static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine().Replace(',','.'));

        Console.Write("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine().Replace(',', '.'));

        Console.Write("Enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine().Replace(',', '.'));

        double sum = firstNumber + secondNumber + thirdNumber;

        Console.WriteLine("{0} + {1} + {2} = {3}", firstNumber, secondNumber, thirdNumber,sum);
    }
}