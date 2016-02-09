using System;

/*  Problem 2. Get largest number
    Write a method GetMax() with two parameters that returns the larger of two integers.
    Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
 */

class GetLargestNumber
{
    static void Main()
    {
        Console.Write("Write first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Write second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Write third number:");
        int thirdNumber = int.Parse(Console.ReadLine());

        int max = GetMax(firstNumber, secondNumber);
        max = GetMax(max, thirdNumber);

        Console.WriteLine("The largest number is: {0}", max);
    }

    static int GetMax(int firstNumber, int secondNumber)
    {
        int max = 0;

        if (firstNumber > secondNumber)
        {
            max = firstNumber;
        }
        else
        {
            max = secondNumber;
        }

        return max;
    }
}