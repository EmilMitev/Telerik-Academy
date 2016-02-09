using System;

/*  Problem 6. Sum integers
    You are given a sequence of positive integer values written into a string, separated by spaces.
    Write a function that reads these values from given string and calculates their sum.
 */

class SumIntegers
{
    static void Main()
    {
        string stringNumbers = "43 68 9 23 318";
        string[] arrayOfStringNumbers = stringNumbers.Split(' ');

        int sum = 0;

        for (int i = 0; i < arrayOfStringNumbers.Length; i++)
        {
            int number = Convert.ToInt32(arrayOfStringNumbers[i]);
            sum += number;
        }
        Console.WriteLine("The sum of the numbers is: {0}", sum);
    }
}