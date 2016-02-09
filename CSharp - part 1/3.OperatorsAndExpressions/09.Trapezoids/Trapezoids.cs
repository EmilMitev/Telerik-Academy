using System;
using System.Globalization;
using System.Threading;

/*  Problem 9. Trapezoids
    Write an expression that calculates trapezoid's area by given sides a and b and height h.
 */
public class Trapezoids
{
    public static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter side a: ");
        double sideA = double.Parse(Console.ReadLine().Replace(',', '.'));

        Console.Write("Enter side b: ");
        double sideB = double.Parse(Console.ReadLine().Replace(',', '.'));

        Console.Write("Enter height h: ");
        double heightH = double.Parse(Console.ReadLine().Replace(',', '.'));

        double area = ((sideA + sideB) / 2) * heightH;
        Console.WriteLine("Trapezoid's area is: " + area);
    }
}