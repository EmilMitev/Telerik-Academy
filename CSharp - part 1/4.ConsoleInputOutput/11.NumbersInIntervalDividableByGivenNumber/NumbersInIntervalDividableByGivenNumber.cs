using System;

/*  Problem 11.* Numbers in Interval Dividable by Given Number
    Write a program that reads two positive integer numbers and prints 
    how many numbers p exist between them such that the reminder of the division by 5 is 0.
 */

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        Console.Write("Enter \"start\" number: ");
        int startNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter \"end\" number: ");
        int endNumber = int.Parse(Console.ReadLine());

        int count = 0;

        Console.WriteLine("Comments: ");
        if (startNumber > endNumber)
        {
            for (int i = startNumber; i >= endNumber; i--)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i + ", ");
                    count++;
                }
            }
        }
        else
        {
            for (int i = startNumber; i <= endNumber; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i + ", ");
                    count++;
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("p = " + count);
    }
}