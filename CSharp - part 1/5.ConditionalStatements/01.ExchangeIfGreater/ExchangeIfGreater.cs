using System;
using System.Threading;
using System.Globalization;
using System.Diagnostics;

/*  Problem 1. Exchange If Greater
    Write an if-statement that takes two double variables a and b and exchanges their values 
    if the first one is greater than the second one. As a result print the values a and b, separated by a space.
 */

class ExchangeIfGreater
{
    static void Main()
    {
        Stopwatch stopWatch = new Stopwatch();

        stopWatch.Start();

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine().Replace(',', '.'));

        Console.Write("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine().Replace(',', '.'));

        if (firstNumber > secondNumber)
        {
            secondNumber += firstNumber;
            firstNumber = secondNumber - firstNumber;
            secondNumber = secondNumber - firstNumber;
        }

        Console.Write("Result: {0} {1} \n", firstNumber, secondNumber);

        stopWatch.Stop();
        TimeSpan ts = stopWatch.Elapsed;

        // Format and display the TimeSpan value. 
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);
    }
}