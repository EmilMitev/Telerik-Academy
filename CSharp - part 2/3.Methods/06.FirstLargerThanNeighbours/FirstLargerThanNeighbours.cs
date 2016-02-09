using System;

/*  Problem 6. First larger than neighbours
    Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
    Use the method from the previous exercise.
 */

class FirstLargerThanNeighbours
{
    static void Main()
    {
        int[] array = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                          1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                          1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};


        int find = CheckTheNeighbours(array);

        if (find>0)
        {
            Console.WriteLine("The number in position {0} is Larger than neighbours ", find);
        }
        else
        {
            Console.WriteLine("There’s no such element");
        }

    }
    static int CheckTheNeighbours(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0)
            {
                if (array[i] > array[i + 1])
                {
                    return i;
                }
            }
            else if (i == array.Length)
            {
                if (array[i] > array[i - 1])
                {
                    return i;
                }
            }
            else
            {
                if ((array[i] > array[i + 1]) && (array[i] > array[i - 1]))
                {
                    return i;
                }
            }
        }
        return -1;
    }
}