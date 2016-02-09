using System;

/*  Problem 1. Numbers from 1 to N
    Write a program that enters from the console a positive integer n and prints all 
        the numbers from 1 to n, on a single line, separated by a space.
 */

class NumbersFromOneToN
{
    static void Main()
    {
        Console.Write("Write a number:");
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("Wrong number.");
        }

        Console.Write("Result: ");

        for (int i = 1; i <= number; i++)
        {
            Console.Write(" {0}",i);
        }

        Console.WriteLine();
    }
}