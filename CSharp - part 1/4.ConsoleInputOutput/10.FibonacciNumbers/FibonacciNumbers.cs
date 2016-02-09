using System;

/*  Problem 10. Fibonacci Numbers
    Write a program that reads a number n and prints on the console the first n members 
    of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
    Note: You may need to learn how to use loops.
 */

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter how many member of the fibonacci sequence you want:");
        int n = int.Parse(Console.ReadLine());
        int[] fibonacciNumbers = new int[n + 1];
        fibonacciNumbers[0] = 0;
        fibonacciNumbers[1] = 1;

        if (n == 1)
        {
            Console.WriteLine(fibonacciNumbers[0]);
        }
        else if (n == 2)
        {

            Console.Write(fibonacciNumbers[0] + ", ");
            Console.Write(fibonacciNumbers[1] + "\n");
        }
        else
        {
            Console.Write("Fibonacci numbers: ");
            Console.Write(fibonacciNumbers[0] + ", ");
            Console.Write(fibonacciNumbers[1] + ", ");
            for (int i = 2; i < n; i++)
            {
                fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2]; ;
                Console.Write(fibonacciNumbers[i] + ", ");
            }

            Console.WriteLine();
        }

    }
}