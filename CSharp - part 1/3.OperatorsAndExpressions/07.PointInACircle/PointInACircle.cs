using System;
using System.Threading;
using System.Globalization;

/*  Problem 7. Point in a Circle
    Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
 */
public class PointInACircle
{
    public static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter x: ");
        double xCoordinate = double.Parse(Console.ReadLine().Replace(',', '.'));

        Console.Write("Enter y: ");
        double yCoordinate = double.Parse(Console.ReadLine().Replace(',', '.'));

        double dx = Math.Pow(xCoordinate, 2);
        double dy = Math.Pow(yCoordinate, 2);

        double radius = 2;
        double dr = Math.Pow(radius, 2);

        bool pointIn = dx + dy <= dr;

        Console.WriteLine(pointIn);
    }
}