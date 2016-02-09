using System;

/*  Problem 2. Compare arrays
    Write a program that reads two integer arrays from the console and compares them element by element.
 */

class CompareArrays
{
    static void Main()
    {
        Console.Write("Enter how many elements do you want in first array:");
        int firstArrayLength = int.Parse(Console.ReadLine());
        int[] firstArrayOfInteger = new int[firstArrayLength];

        Console.WriteLine("Enter an element(integer) on first array each on a single line:");
        for (int i = 0; i < firstArrayLength; i++)
        {
            firstArrayOfInteger[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter how many elements do you want in second array:");
        int secondArrayLength = int.Parse(Console.ReadLine());
        int[] secondArrayOfInteger = new int[secondArrayLength];

        Console.WriteLine("Enter an element(integer) on first array each on a single line:");
        for (int i = 0; i < secondArrayLength; i++)
        {
            secondArrayOfInteger[i] = int.Parse(Console.ReadLine());
        }

        bool isEqual = true;

        if (firstArrayLength == secondArrayLength)
        {
            for (int i = 0; i < firstArrayLength; i++)
            {
                if (firstArrayOfInteger[i] != secondArrayOfInteger[i])
                {
                    isEqual = false;
                    break;
                }
            }
        }
        else
        {
            isEqual = false;
        }

        if (isEqual)
        {
            Console.WriteLine("The arrays are equal.");
        }
        else
        {
            Console.WriteLine("The arrays are not equal.");
        }
    }
}