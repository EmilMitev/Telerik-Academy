using System;

/*  Problem 1. Leap year
    Write a program that reads a year from the console and checks whether it is a leap one.
    Use System.DateTime.
 */

class LeapYear
{
    static void Main()
    {
        Console.Write("Enter an year: ");
        int year = int.Parse(Console.ReadLine());
        DateTime time = new DateTime(year);
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("{0} is leap", year);
        }
        else
        {
            Console.WriteLine("{0} is not leap", year);
        }
    }
}