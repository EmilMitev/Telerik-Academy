using System;
using System.Globalization;
using System.Threading;

/*  Problem 6. The Biggest of Five Numbers
    Write a program that finds the biggest of five numbers by using only five if statements.
 */

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("First number:");
        double firstNumber = double.Parse(Console.ReadLine().Replace(',','.'));

        Console.Write("Second number:");
        double secondNumber = double.Parse(Console.ReadLine().Replace(',', '.'));

        Console.Write("Third number:");
        double thirdNumber = double.Parse(Console.ReadLine().Replace(',', '.'));

        Console.Write("Fourth number:");
        double fourthNumber = double.Parse(Console.ReadLine().Replace(',', '.'));

        Console.Write("Fifth number:");
        double fifthNumber = double.Parse(Console.ReadLine().Replace(',', '.'));


        if (firstNumber >= secondNumber && firstNumber >= thirdNumber && firstNumber >= fourthNumber && firstNumber >= fifthNumber)
        {
            Console.WriteLine("Biggest: " + firstNumber);
        }
        else if (secondNumber >= firstNumber && secondNumber >= thirdNumber && secondNumber >= fourthNumber && secondNumber >= fifthNumber)
        {
            Console.WriteLine("Biggest: " + secondNumber);
        }
        else if (thirdNumber >= firstNumber && thirdNumber >= secondNumber && thirdNumber >= fourthNumber && thirdNumber >= fifthNumber)
        {
            Console.WriteLine("Biggest: " + thirdNumber);
        }
        else if (fourthNumber >= firstNumber && fourthNumber >= secondNumber && fourthNumber >= thirdNumber && fourthNumber >= fifthNumber)
        {
            Console.WriteLine("Biggest: " + fourthNumber);
        }
        else if (fifthNumber >= firstNumber && fifthNumber >= secondNumber && fifthNumber >= thirdNumber && fifthNumber >= fourthNumber)
        {
            Console.WriteLine("Biggest: " + fifthNumber);
        }
    }
}