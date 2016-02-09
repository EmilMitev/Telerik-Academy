using System;
using System.Threading;
using System.Globalization;

/*  Problem 5. Formatting Numbers
    Write a program that reads 3 numbers:
    integer a (0 <= a <= 500)
    floating-point b
    floating-point c
    The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
        The number a should be printed in hexadecimal, left aligned
        Then the number a should be printed in binary form, padded with zeroes
        The number b should be printed with 2 digits after the decimal point, right aligned
        The number c should be printed with 3 digits after the decimal point, left aligned.
 */
public class FormattingNumbers
{
    public static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter integer number a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter foating-point b: ");
        float b = float.Parse(Console.ReadLine().Replace(',', '.'));

        Console.Write("Enter foating-point c: ");
        float c = float.Parse(Console.ReadLine().Replace(',', '.'));

        int binnaryA = int.Parse(Convert.ToString(a, 2));

        Console.WriteLine("Result: {0,-10:X}|{1,10:D10}|{2,10:F2}|{3,-10:F3}|", a, binnaryA, b, c);
    }
}