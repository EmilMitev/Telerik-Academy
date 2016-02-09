using System;
using System.Globalization;

/*  Problem 16. Date difference
    Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
 */

class DateDifference
{
    static void Main()
    {
        Console.Write("Enter date(dd.MM.yyyy): ");
        string firstDate = Console.ReadLine();
        DateTime first = DateTime.ParseExact(firstDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);

        Console.Write("Enter date(d.MM.yyyy): ");
        string secondDate = Console.ReadLine();
        DateTime second = DateTime.ParseExact(secondDate, "d.MM.yyyy", CultureInfo.InvariantCulture);

        TimeSpan span = first.Subtract(second);
        Console.WriteLine(Math.Abs(span.Days));
    }
}