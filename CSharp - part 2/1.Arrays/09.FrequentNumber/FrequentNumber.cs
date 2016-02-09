using System;

/*  Problem 9. Frequent number
    Write a program that finds the most frequent number in an array.
 */

class FrequentNumber
{
    static void Main()
    {
        int[] arrayOfNumbers = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

        int count = 0;
        int mostFrequentNumber = 0;

        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            int tempCount = 0;
            for (int j = 0; j < arrayOfNumbers.Length; j++)
            {
                if (arrayOfNumbers[i] == arrayOfNumbers[j])
                {
                    ++tempCount;
                }
            }
            if (tempCount >= count)
            {
                count = tempCount;
                mostFrequentNumber = arrayOfNumbers[i];
            }
        }
        Console.WriteLine("Result is: {0} ({1} times)", mostFrequentNumber, count);
    }
}