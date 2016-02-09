using System;
/*  Problem 6. Four-Digit Number
    Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
        Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
        Prints on the console the number in reversed order: dcba (in our example 1102).
        Puts the last digit in the first position: dabc (in our example 1201).
        Exchanges the second and the third digits: acbd (in our example 2101).
    The number has always exactly 4 digits and cannot start with 0.
 */
public class FourDigitNumber
{
    public static void Main()
    {
        Console.Write("Enter four-digit number:");
        int number = int.Parse(Console.ReadLine());

        if (number < 1000 || number > 9999)
        {
            Console.WriteLine("WRONG NUMBER!!!");
        }
        else
        {
            int a = (number / 1000) % 10;
            int b = (number / 100) % 10;
            int c = (number / 10) % 10;
            int d = number % 10;

            int sumOfDigits = a + b + c + d;

            Console.WriteLine("The sum of the digits is: " + sumOfDigits);
            Console.WriteLine("Prints on the console the number in reversed order:{0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("Puts the last digit in the first position:{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("Exchanges the second and the third digits:{0}{1}{2}{3}", a, c, b, d);
        }
    }
}