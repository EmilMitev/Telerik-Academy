using System;

/*  Problem 14. Integer calculations
    Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
    Use variable number of arguments.
 */

class IntegerCalculations
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        Console.WriteLine("Min number is: {0}", Minimum(numbers));
        Console.WriteLine("Max number is: {0}", Maximum(numbers));
        Console.WriteLine("Average of the numbers is: {0}", Average(numbers));
        Console.WriteLine("Sum of the number is: {0}", Sum(numbers));
        Console.WriteLine("Product of the numbers is: {0}", Product(numbers));
    }

    static int Product(int[] numbers)
    {
        int product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }

    static int Sum(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }

    static double Average(int[] numbers)
    {
        double average = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            average += numbers[i];
        }
        average /= numbers.Length;
        return average;
    }

    static int Maximum(int[] numbers)
    {
        int max = int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }

    static int Minimum(int[] numbers)
    {
        int min = int.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        return min;
    }
}