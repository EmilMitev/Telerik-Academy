using System;

/*  Problem 17.* Calculate GCD
    Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
    Use the Euclidean algorithm (find it in Internet).
 */

class CalculateGCD
{
    static void Main()
    {
        Console.Write("Enter first number(a): ");
        int firsfNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter second number(b): ");
        int secondNumber = int.Parse(Console.ReadLine());

        int number;

        while (secondNumber!=0)
        {
            number = secondNumber;
            secondNumber = firsfNumber % secondNumber;
            firsfNumber = number;
        }

        Console.WriteLine("GCD(a, b) = " + firsfNumber);
    }
}