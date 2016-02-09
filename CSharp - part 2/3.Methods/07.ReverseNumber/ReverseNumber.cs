using System;

/*  Problem 7. Reverse number
    Write a method that reverses the digits of given decimal number.
 */

class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter your number: ");
        decimal number = decimal.Parse(Console.ReadLine());
        decimal reverseNumber = ReverseDigits(number);
        Console.WriteLine("Reverse number is: {0}", reverseNumber);
    }

    static decimal ReverseDigits(decimal number)
    {
        decimal reverseNumber = 0;
        char[] array = number.ToString().ToCharArray();
        Array.Reverse(array);
        reverseNumber = decimal.Parse(String.Join("", array));
        return reverseNumber;
    }
}