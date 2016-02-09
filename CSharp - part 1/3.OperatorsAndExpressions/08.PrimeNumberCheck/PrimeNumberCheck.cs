using System;

/*  Problem 8. Prime Number Check
    Write an expression that checks if given positive integer number n (n = 100) 
    is prime (i.e. it is divisible without remainder only to itself and 1).
 */
public class PrimeNumberCheck
{
    public static void Main()
    {
        Console.Write("Enter yor number:");
        int number = int.Parse(Console.ReadLine());
        int sqrtNumber = (int)Math.Sqrt(number);
        int count = 1;

        for (int i = 1; i <= sqrtNumber; i++)
        {
            if (number == 0 || number == 1)
            {
                continue;
            }
            else
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
        }

        if (count == 2)
        {
            Console.WriteLine("Prime? - True");
        }
        else
        {
            Console.WriteLine("Prime? - false");
        }
    }
}