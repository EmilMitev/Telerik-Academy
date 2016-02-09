using System;

/*  Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
    Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
    Use only one loop. Print the result with 5 digits after the decimal point.
 */

class Calculate
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());

        double result = 1;
        int factorial = 1;
        int powerX = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            powerX *= x;

            result += (double)factorial / powerX;
        }
        Console.WriteLine("Result is: {0:F5}", result);
    }
}