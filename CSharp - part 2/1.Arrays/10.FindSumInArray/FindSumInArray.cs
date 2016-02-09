using System;

/*  Problem 10. Find sum in array
    Write a program that finds in given array of integers a sequence of given sum S (if present).
 */

class FindSumInArray
{
    static void Main()
    {
        int[] arrayOfNumbers = { 2, 1, 3, 1, 4, 4, 8, 8, 2 };

        int sum = 11;
        int start = 0;
        int end = 0;

        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            int tempSum = 0;
            for (int j = i; j < arrayOfNumbers.Length; j++)
            {
                tempSum += arrayOfNumbers[j];
                if (tempSum == sum)
                {
                    start = i;
                    end = j;
                }
            }
        }

        for (int i = start; i <= end; i++)
        {
            if (i==end)
            {
                Console.Write("{0}", arrayOfNumbers[i]);
            }
            else
            {
                Console.Write("{0}, ", arrayOfNumbers[i]);
            }
        }
        Console.WriteLine();
    }
}