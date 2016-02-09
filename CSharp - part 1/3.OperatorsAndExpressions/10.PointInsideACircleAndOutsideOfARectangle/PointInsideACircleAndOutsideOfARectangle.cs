using System;
using System.Threading;
using System.Globalization;

/*  Problem 10. Point Inside a Circle & Outside of a Rectangle
    Write an expression that checks for given point (x, y) if it is within 
    the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
 */
public class PointInsideACircleAndOutsideOfARectangle
{
    public static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter x coordinate:");
        double xCoordinate = double.Parse(Console.ReadLine().Replace(',', '.'));

        Console.Write("Enter y coordinate:");
        double yCoordinate = double.Parse(Console.ReadLine().Replace(',', '.'));

        bool isOutOfRectangle = false;
        bool isInTheCircle = false;

        if ((xCoordinate < -1 || xCoordinate > 5) || (yCoordinate < -1 || yCoordinate > 1))
        {
            isOutOfRectangle = true;
        }

        double xPow = Math.Pow((xCoordinate - 1), 2);
        double yPow = Math.Pow((xCoordinate - 1), 2);
        double rPow = Math.Pow(1.5, 2);

        if ((xPow + yPow) < rPow)
        {
            isInTheCircle = true;
        }

        Console.WriteLine(isInTheCircle && isOutOfRectangle ? "inside K & outside of R - YES" : "inside K & outside of R - NO");
    }
}