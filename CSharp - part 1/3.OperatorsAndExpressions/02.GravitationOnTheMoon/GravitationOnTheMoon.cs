using System;
using System.Threading;
using System.Globalization;

/*  Problem 2. Gravitation on the Moon
    The gravitational field of the Moon is approximately 17% of that on the Earth.
    Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
 */
public class GravitationOnTheMoon
{
    public static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter your kilogram:");
        decimal kilogramOnEarth = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Your kilogram on Earth is: " + kilogramOnEarth);

        decimal kilogramOnMoon = kilogramOnEarth * 0.17M;

        Console.WriteLine("Your kilogram on Moon is: " + kilogramOnMoon);
    }
}