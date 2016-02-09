using System;
using System.Threading;
using System.Globalization;

/*  Problem 6. Quadratic Equation
    Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
 */

public class QuadraticEquation
{
    public static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("ax^2 + bx + c = 0");
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine().Replace(',', '.'));

        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine().Replace(',', '.'));

        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine().Replace(',', '.'));

        double x = 0;

        if (a == 0)
        {
            x = -c / b;
            Console.WriteLine("x = " + x);
        }
        else
        {
            double D = Math.Pow(b, 2) - 4 * a * c;
            double x1 = 0, x2 = 0;

            if (D > 0)
            {
                x1 = (-b - Math.Sqrt(D)) / (2 * a);
                x2 = (-b + Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
            }
            else if (D == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("x1 = x2 = " + x1);
            }
            else
            {
                Console.WriteLine("Result: no real roots.");
            }
        }
    }
}