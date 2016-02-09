using System;
using System.Numerics;

/*  Problem 7. Calculate N! / (K! * (N-K)!)
    In combinatorics, the number of ways to choose k different members out of a group of n different elements 
    (also known as the number of combinations) is calculated by the following formula: formula For example, 
    there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
    Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
 */


class CalculateTheNumberOfCombinations
{
    static void Main()
    {
        Console.Write("Enter n(1 < k < n < 100): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k(1 < k < n < 100): ");
        int k = int.Parse(Console.ReadLine());

        if ((1 > k || k > n || n > 100))
        {
            Console.WriteLine("Wrong numbers!");
        }
        else
        {
            BigInteger NFactorial = 1;
            BigInteger KFactorial = 1;
            BigInteger NKFactorial = 1;
            BigInteger result = 0;

            for (int i = 1; i <= n; i++)
            {
                NFactorial *= i;

                if (!(k < i))
                {
                    KFactorial *= i;
                }

                if (!((n - k) < i))
                {
                    NKFactorial *= i;
                }
            }

            result = NFactorial / (KFactorial * NKFactorial);
            Console.WriteLine("Result is: " + result);
        }
    }
}