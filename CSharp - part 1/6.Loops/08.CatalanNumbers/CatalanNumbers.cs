using System;
using System.Numerics;

/*  Problem 8. Catalan Numbers
    In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
    Write a program to calculate the nth Catalan number by given n (1 <= n <= 100).
 */

class CatalanNumbers
{
    static void Main()
    {

        Console.Write("Enter n(0 <= n <= 100): ");
        int n = int.Parse(Console.ReadLine());

        if (0 > n || n > 100)
        {
            Console.WriteLine("Wrong number!");
        }

        BigInteger twoNFactorial = 1;
        BigInteger onePlusNFactorial = 1;
        BigInteger NFactorial = 1;
        BigInteger result = 0;

        int doubleN = 2 * n;

        for (int i = 1; i <= doubleN; i++)
        {
            twoNFactorial *= i;

            if (!(doubleN / 2 < i))
            {
                NFactorial *= i;
            }

            if (!((n + 1) < i))
            {
                onePlusNFactorial *= i;
            }
        }

        result = twoNFactorial / (onePlusNFactorial * NFactorial);
        Console.WriteLine("Result is: " + result);
    }
}