﻿using System;

/*  Problem 9. Matrix of Numbers
    Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.
 */

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Enter n(1 <= n <= 20): ");
        int n = int.Parse(Console.ReadLine());

        if (1 > n || n > 20)
        {
            Console.WriteLine("Wrong numbers:");
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < i + n; j++)
                {
                    Console.Write("{0,2}", j);
                }
                Console.WriteLine();
            }
        }
    }
}