using System;
using System.Linq;

/* Problem 5. Larger than neighbours
    Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
 */

class LargerThanNeighbours
{
    static void Main()
    {
        int[] array = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 10, 13, 14, 15, 16, 17, 18, 19, 20,
                          1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                          1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
        int position = 20;
        bool isTrue = CheckTheNeighbours(array, position);
        if (isTrue)
        {
            Console.WriteLine("The number in position {0} is Larger than neighbours ", position);
        }
        else
        {
            Console.WriteLine("The number in position {0} is NOT Larger than neighbours ", position);
        }

    }

    static bool CheckTheNeighbours(int[] array, int position)
    {
        if (position == 0)
        {
            if (!(array[position] > array[position + 1]))
            {
                return false;
            }
        }
        else if (position == array.Length)
        {
            if (!(array[position] > array[position - 1]))
            {
                return false;
            }
        }
        else
        {
            if (!(array[position] > array[position + 1] && (array[position] > array[position - 1])))
            {
                return false;
            }
        }
        return true;
    }
}