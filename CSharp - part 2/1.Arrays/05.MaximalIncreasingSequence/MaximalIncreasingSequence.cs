using System;

/*  Problem 5. Maximal increasing sequence
    Write a program that finds the maximal increasing sequence in an array.
 */

class MaximalIncreasingSequence
{
    static void Main()
    {
        int[] arrayOfNumbers = { 3, 2, 3, 4, 2, 2, 4 };// if you want you can try with your number(that way is easier than you enter from the console)

        //but if you want
        //Console.Write("Enter how many elements do you want in array: ");
        //int length = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter an element(integer) on array each on a single line:");
        //for (int i = 0; i < length; i++)
        //{
        //    array[i] = int.Parse(Console.ReadLine());
        //}

        int end = 0;
        int longest = 1;
        int currentLongest = 1;

        for (int i = 0; i < arrayOfNumbers.Length - 1; i++)
        {

            if (arrayOfNumbers[i] + 1 == arrayOfNumbers[i + 1])
            {
                end = i + 1;
                currentLongest++;
            }
            else
            {
                if (currentLongest > longest)
                {
                    longest = currentLongest;
                }
                currentLongest = 1;
            }
        }

        if (currentLongest > longest)
        {
            longest = currentLongest;
        }

        Console.Write("Result is: ");
        for (int i = end - longest + 1; i <= end; i++)
        {
            if (i == end)
            {
                Console.Write(arrayOfNumbers[i]);
            }
            else
            {
                Console.Write("{0}, ", arrayOfNumbers[i]);
            }
        }
        Console.WriteLine();
    }
}