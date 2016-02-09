using System;

/*  Problem 9. Sorting array
    Write a method that return the maximal element in a portion of array of integers starting at given index.
    Using it write another method that sorts an array in ascending / descending order.
 */

class SortingArray
{
    static void Main()
    {
        int[] array = { 3, 9, 1, 4, 6, 5, 8, 7, 2 };
        int position = 5;
        int biggestNumberPosition = MaxElementInPortion(array, position);

        Console.WriteLine("Max number after {0} position is: {1}", position, array[biggestNumberPosition]);

        SortArray(array);

        Console.WriteLine(String.Join(" ", array));
    }

    public static int MaxElementInPortion(int[] array, int starting)
    {
        int max = -1;
        int index = -1;

        for (int i = starting; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index = i;
            }
        }
        return index;
    }

    static void SortArray(int[] array)
    {
        int max = int.MinValue;
        int maxIndex = -1;

        for (int i = 0; i < array.Length - 1; i++)
        {
            maxIndex = MaxElementInPortion(array, i);
            max = array[maxIndex];


            if (array[i] < max)
            {
                int temp = array[i];
                array[i] = max;
                array[maxIndex] = temp;
            }
        }
    }
}