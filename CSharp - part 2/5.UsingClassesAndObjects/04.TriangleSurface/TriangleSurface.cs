using System;

/*  Problem 4. Triangle surface

    Write methods that calculate the surface of a triangle by given:
    Side and an altitude to it;
    Three sides;
    Two sides and an angle between them;
    Use System.Math.
 */

class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine("{0:F2}", GetAreaWithAltitude(23.2, 5));
        Console.WriteLine("{0:F2}", GetAreaWithHeron(11, 12, 13));
        Console.WriteLine("{0:F2}", GetAreaWithAngle(10, 7, 25));
    }

    static double GetAreaWithAltitude(double a, double h)
    {
        return (a * h) / 2;
    }

    static double GetAreaWithHeron(double a, double b, double c)
    {
        double p = (a + b + c) / 2;

        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    static double GetAreaWithAngle(double a, double b, double alpha)
    {
        return (a * b * Math.Sin(Math.PI * alpha / 180)) / 2;
    }




}