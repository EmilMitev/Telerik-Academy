using System;
using System.Globalization;
using System.Threading;

/*  Problem 4. Multiplication Sign
    Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
    Use a sequence of if operators.
 */

class MultiplicationSign
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine().Replace(',', '.'));

        Console.Write("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine().Replace(',', '.'));

        Console.Write("Enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine().Replace(',', '.'));

        bool firstCheckSign = firstNumber > 0;
        bool secondCheckSign = secondNumber > 0;
        bool thirdCheckSign = thirdNumber > 0;

        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine("Result: 0");
        }
        else if (firstCheckSign ^ secondCheckSign ^ thirdCheckSign)
        {
            Console.WriteLine("The sign will be \"+\"");
        }
        else
        {
            Console.WriteLine("The sign will be \"-\"");
        }
    }
}