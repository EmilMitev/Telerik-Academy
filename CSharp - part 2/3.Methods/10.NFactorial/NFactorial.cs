using System;

/*  Problem 10. N Factorial
    Write a program to calculate n! for each n in the range [1..100].
 */

class NFactorial
{
    static void Main()
    {
        Console.Write("Enter number[1...100]: ");
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine("{0}! = {1}", i, Factorial(i));
        }
    }

    static long Factorial(int number)
    {
        long factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}