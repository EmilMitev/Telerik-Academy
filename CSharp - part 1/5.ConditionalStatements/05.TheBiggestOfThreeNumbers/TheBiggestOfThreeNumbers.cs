using System;
using System.Threading;
using System.Globalization;

/*  Problem 5. The Biggest of 3 Numbers
    Write a program that finds the biggest of three numbers.
 */

class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());


        if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
        {
            Console.WriteLine("{0} is biggest", firstNumber);
        }
        else if (firstNumber <= thirdNumber && secondNumber <= thirdNumber)
        {
            Console.WriteLine("{0} is biggest", thirdNumber);
        }
        else 
        {
            Console.WriteLine("{0} is biggest", secondNumber);           
        }
    }
}