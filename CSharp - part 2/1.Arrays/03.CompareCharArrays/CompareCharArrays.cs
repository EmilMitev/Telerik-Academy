using System;

/*  Problem 3. Compare char arrays
    Write a program that compares two char arrays lexicographically (letter by letter).
 */

class CompareCharArrays
{
    static void Main()
    {
        Console.Write("Enter how many elements do you want in first array:");
        int firstArrayLength = int.Parse(Console.ReadLine());
        char[] firstArrayOfChar = new char[firstArrayLength];

        Console.WriteLine("Enter an element(char) on first array each on a single line:");
        for (int i = 0; i < firstArrayLength; i++)
        {
            firstArrayOfChar[i] = char.Parse(Console.ReadLine());
        }

        Console.Write("Enter how many elements do you want in second array:");
        int secondArrayLength = int.Parse(Console.ReadLine());
        char[] secondArrayOfChar = new char[secondArrayLength];

        Console.WriteLine("Enter an element(char) on first array each on a single line:");
        for (int i = 0; i < secondArrayLength; i++)
        {
            secondArrayOfChar[i] = char.Parse(Console.ReadLine());
        }

        bool isEqual = true;

        if (firstArrayLength == secondArrayLength)
        {
            for (int i = 0; i < firstArrayLength; i++)
            {
                if (firstArrayOfChar[i] != secondArrayOfChar[i])
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