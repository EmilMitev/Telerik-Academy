using System;

/*  Problem 1. Odd or Even Integers
    Write an expression that checks if given integer is odd or even.
*/
public class OddOrEvenIntegers
{
    public static void Main()
    {
        Console.Write("Enter your number: ");
        int number = int.Parse(Console.ReadLine());

        bool isOdd = number % 2 != 0;

        Console.WriteLine("Odd? - " + isOdd);
    }
}