using System;
using System.Collections.Generic;

/*  Problem 15. Prime numbers
    Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
 */

class PrimeNumbers
{
    static void Main()
    {
        List<int> listOfIntegers = new List<int>();

        int howManyNumbers = 10000000;//you should wait a lot of time 
                                      //if you want you can try with number < 1 000 to check an algorithm

        for (int i = 2; i <= howManyNumbers; i++)
        {
            listOfIntegers.Add(i);
        }

        int temp = 0;
        listOfIntegers.Remove(121);

        Console.WriteLine("You should wait a lot!");
        for (int i = 0; i < Math.Sqrt(listOfIntegers.Count); i++)
        {
            temp = listOfIntegers[i];
            for (int j = 0; j < listOfIntegers.Count; j++)
            {
                temp += listOfIntegers[i];
                listOfIntegers.Remove(temp);
            }
        }
        for (int i = 0; i < listOfIntegers.Count; i++)
        {
            if (i==listOfIntegers.Count-1)
            {
                Console.Write(listOfIntegers[i]);
            }
            else
            {
                Console.Write("{0}, ", listOfIntegers[i]);
            }
        }
        Console.WriteLine();
    }
}