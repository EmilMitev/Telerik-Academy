using System;
using System.Globalization;

/*  Problem 17. Date in Bulgarian

    Write a program that reads a date and time given in the format: day.month.year hour:minute:second and 
    prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
 */

class DateInBulgarian
{
    static void Main()
    {
        CultureInfo info = new CultureInfo("bg-BG");
        Console.Write("Enter date(dd.MM.yyyy HH:mm:ss): ");
        string date = Console.ReadLine();
        DateTime first = DateTime.ParseExact(date, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

        first.AddHours(6);
        first.AddMinutes(30);

        Console.WriteLine("{0:d.M.yyyy HH:mm:ss} - {0:dddd}",first);
    }
}