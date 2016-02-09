using System;
using System.Globalization;
using System.Threading;

/*  Problem 3. Circle Perimeter and Area
    Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
 */
public class CirclePerimeterAndArea
{
    public static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter radius of a circle: ");
        double radius = double.Parse(Console.ReadLine().Replace(',', '.'));

        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * Math.Pow(radius, 2);

        Console.WriteLine("Perimeter: {0:F2}", perimeter);
        Console.WriteLine("Area: {0:F2}", area);
    }
}