using System;

/*  Problem 6. Calculate N! / K!
    Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
    Use only one loop.
 */

class CalculateNK
{
    static void Main()
    {
        Console.Write("Enter n(1 < k < n < 100).: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k(1 < k < n < 100).: ");
        int k = int.Parse(Console.ReadLine());

        if (!(1 < k || k < n || n < 100))
        {
            Console.WriteLine("Wrong number!");
        }

        int result = 0;
        int NFactorial = 1;
        int KFactorial = 1;

        for (int i = 1; i <= n; i++)
        {
            NFactorial *= i;

            if (!(k < i))
            {
                KFactorial *= i;
                continue;
            }
        }
        result = NFactorial / KFactorial;
        Console.WriteLine("Result is: {0}", result);
    }
}