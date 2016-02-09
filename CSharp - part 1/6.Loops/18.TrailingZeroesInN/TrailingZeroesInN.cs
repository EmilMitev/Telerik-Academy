using System;
using System.Numerics;

/*  Problem 18.* Trailing Zeroes in N!
    Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
    Your program should work well for very big numbers, e.g. n=100000.
 */

class TrailingZeroesInN
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        BigInteger factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        string str = factorial.ToString();

        int count = 0;

        for (int i = str.Length - 1; i >= 0; i--)
        {
            if (str[i].Equals('0'))
            {
                ++count;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine("Explaination: " + str);
        Console.WriteLine("Trailing zeroes of n! = " + count);
    }
}