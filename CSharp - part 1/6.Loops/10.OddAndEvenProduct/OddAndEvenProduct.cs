using System;

/*  Problem 10. Odd and Even Product
    You are given n integers (given in a single line, separated by a space).
    Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
    Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
 */

class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter numbers(in a single line, separated by a space)");
        string numbers = Console.ReadLine();

        string[] number = numbers.Split(' ');

        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < number.Length; i++)
        {
            if (i == 0)
            {
                oddProduct *= int.Parse(number[i]);
            }
            else if (i%2!=0)
            {
                evenProduct *= int.Parse(number[i]);
            }
            else
            {
                oddProduct *= int.Parse(number[i]);
            }
        }

        if (oddProduct==evenProduct)
        {
            Console.WriteLine("Product = " + evenProduct);
            Console.WriteLine("Result: YES");
        }
        else
        {
            Console.WriteLine("Odd product: " + oddProduct);
            Console.WriteLine("Even product: " + evenProduct);
            Console.WriteLine("Result: NO");
        }
    }
}