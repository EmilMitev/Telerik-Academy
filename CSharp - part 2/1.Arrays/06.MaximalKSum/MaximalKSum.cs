using System;

/*  Problem 6. Maximal K sum
    Write a program that reads two integer numbers N and K and an array of N elements from the console.
    Find in the array those K elements that have maximal sum.
 */

class MaximalKSum
{
    static void Main()
    {
        Console.Write("Enter how many elements do you want in array: ");
        int nElements = int.Parse(Console.ReadLine());

        Console.Write("How many elements do you want to sum: ");
        int kElements = int.Parse(Console.ReadLine());

        int[] arrayOfNumbers = new int[nElements];

        Console.WriteLine("Enter an element(integer) on first array each on a single line:");
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            arrayOfNumbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arrayOfNumbers);
        int sum = 0;

        for (int i = arrayOfNumbers.Length - 1; i >= arrayOfNumbers.Length - kElements; i--)
        {
            sum += arrayOfNumbers[i];
        }

        Console.WriteLine("The max sum of K elements is: {0}", sum);
    }
}