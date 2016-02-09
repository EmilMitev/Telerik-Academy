using System;

/*  Problem 12.* Randomize the Numbers 1…N
    Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
 */

class RandomizeTheNumbersOneToN
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int n = int.Parse(Console.ReadLine());

        int[] arrayOfNumbers = new int[n];
        int count = 0;

        Random random = new Random();
        int number;
        int i = 0;

        do
        {
            count = 0;
            number = random.Next(1, n + 1);

            for (int j = 0; j < n; j++)
            {
                if (number == arrayOfNumbers[j])
                {
                    ++count;
                }
            }

            if (count == 0)
            {
                arrayOfNumbers[i] = number;
                i++;
            }
        } while (arrayOfNumbers[n-1]==0);


        //Second solution
        //Console.WriteLine("I'm thinking! WAIT!");
        //beforeFor:
        //for (int i = 0; i < n; i++)
        //{
        //    count = 0;
        //    number = random.Next(1, n + 1);

        //    for (int j = 0; j < n; j++)
        //    {
        //        if (number == arrayOfNumbers[j])
        //        {
        //            ++count;
        //        }
        //    }

        //    if (count==0)
        //    {
        //        arrayOfNumbers[i] = number;
        //    }
        //    else
        //    {
        //        goto beforeFor;
        //    }
        //}

        Console.WriteLine("Randomized numbers 1...n: ");

        for (i = 0; i < arrayOfNumbers.Length; i++)
        {
            Console.WriteLine(arrayOfNumbers[i]);
        }
    }
}