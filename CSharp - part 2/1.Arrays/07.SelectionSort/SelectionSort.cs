using System;

/*  Problem 7. Selection sort
    Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
    Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
 */

class SelectionSort
{
    static void Main()
    {
        int[] arrayOfNumbers = { 805, 21, 6, 5, -734, 65, 4, 26, 7 };

        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            for (int j = i; j < arrayOfNumbers.Length; j++)
            {
                if (arrayOfNumbers[i] >= arrayOfNumbers[j])
                {
                    int temp = arrayOfNumbers[j];
                    arrayOfNumbers[j] = arrayOfNumbers[i];
                    arrayOfNumbers[i] = temp;
                }
            }
        }
        Console.WriteLine(string.Join(", ", arrayOfNumbers));
    }
}