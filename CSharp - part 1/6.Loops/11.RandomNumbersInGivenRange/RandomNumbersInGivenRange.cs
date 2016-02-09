using System;

/*  Problem 11. Random Numbers in Given Range
    Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
 */

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("Enter how many number you want: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter min: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter max: ");
        int max = int.Parse(Console.ReadLine());

        Random random = new Random();
        Console.Write("Random numbers: ");

        for (int i = 0; i < n; i++)
        {
            int number = random.Next(min, (max+1));
            Console.Write(number + " ");
        }
        Console.WriteLine("\nThe above output is just an example. \nDue to randomness, your program most probably will produce different results!!!!");
    }
}