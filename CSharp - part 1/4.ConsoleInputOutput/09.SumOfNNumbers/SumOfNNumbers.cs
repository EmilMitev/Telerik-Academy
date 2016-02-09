using System;
using System.Globalization;
using System.Threading;

/*  Problem 9. Sum of n Numbers
    Write a program that enters a number n and after that enters 
    more n numbers and calculates and prints their sum. 
    Note: You may need to use a for-loop
 */

class SumOfNNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter how many numbers you want: ");
        int n = int.Parse(Console.ReadLine());

        double number;
        double sum = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} number = ", i);
            number = double.Parse(Console.ReadLine());
            sum += number;
        }

        Console.WriteLine("Sum of your numbers is: " + sum);
    }
}