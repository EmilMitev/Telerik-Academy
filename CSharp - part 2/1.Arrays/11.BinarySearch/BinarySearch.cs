using System;

/*  Problem 11. Binary search
    Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
 */

class BinarySearch
{
    static void Main()
    {
        int[] arrayOfNumbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        int valueToBeFound = 12;

        int index = 0;
        int left = 0;
        int right = arrayOfNumbers.Length;

        while (true)
        {
            int middle = (left + right) / 2;
            if (arrayOfNumbers[middle] == valueToBeFound)
            {
                index = middle;
                break;
            }
            else if (arrayOfNumbers[middle] > valueToBeFound)
            {
                left -= 1;
            }
            else if (arrayOfNumbers[middle] < valueToBeFound)
            {
                right += 1;
            }
        }

        Console.WriteLine("Element that you search is on {0} index.", index);  //The counting start from 0
    }
}