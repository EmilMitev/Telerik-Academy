using System;

/*  Problem 5. Third Digit is 7?
    Write an expression that checks for given integer if its third digit from right-to-left is 7.
 */
public class ThirdDigitIsSeven
{
    public static void Main()
    {
        Console.Write("Enter number:");
        int number = int.Parse(Console.ReadLine());

        bool isSeven = (number / 100) % 10 == 7;

        Console.WriteLine("Third digit from right-to-left is 7? - " + isSeven);
    }
}