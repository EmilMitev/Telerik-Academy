using System;

/*  Problem 4. Appearance count
    Write a method that counts how many times given number appears in given array.
    Write a test program to check if the method is workings correctly.
 */

class AppearanceCount
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};

        Console.Write("Enter number for search: ");
        int number = int.Parse(Console.ReadLine());
        int count = CountSpecialNumberInArray(number, array);
        Console.WriteLine("The number {0} appears {1} times in array.", number, count);
    }

    static int CountSpecialNumberInArray(int number, int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (number == array[i])
            {
                ++count;
            }
        }
        return count;
    }
}