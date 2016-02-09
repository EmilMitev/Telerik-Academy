using System;

/*  Problem 3. Min, Max, Sum and Average of N Numbers
    Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
    The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
    The output is like in the examples below.
 */

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("Write your number n (alone in a line) followed by n lines: ");
        int firstNumber = int.Parse(Console.ReadLine());

        int min = int.MaxValue;
        int max = int.MinValue;
        int sum = 0;
        int count = 0;
        int number;
        double average;

        for (int i = 1; i <= firstNumber; i++)
        {
            number = int.Parse(Console.ReadLine());

            if (number >= max)
            {
                max = number;
            }

            if (number <= min)
            {
                min = number;
            }

            sum += number;
            count++;
        }

        average = (double)sum / count;
        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:F2}", average);
    }
}