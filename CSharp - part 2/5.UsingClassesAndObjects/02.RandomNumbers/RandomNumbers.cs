using System;

/*  Problem 2. Random numbers
    Write a program that generates and prints to the console 10 random values in the range [100, 200].
 */

class RandomNumbers
{
    static void Main()
    {
        Random randomGenerator = new Random();
        Console.WriteLine("Your random numbers is:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(randomGenerator.Next(100, 201));
        }
    }
}