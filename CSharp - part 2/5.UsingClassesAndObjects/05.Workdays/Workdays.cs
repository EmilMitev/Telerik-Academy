using System;
using System.Globalization;

/*  Problem 5. Workdays
    Write a method that calculates the number of workdays between today and given date, passed as parameter.
    Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array. 
 */

class Workdays
{
    static void Main()
    {
        Console.Write("Enter date(dd.MM.yyyy): ");
        string date = Console.ReadLine();
        int year = DateTime.ParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture).Year;
        TimeSpan span = DateTime.ParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture).Subtract(DateTime.Now);
        

        DateTime[] holidays = { new DateTime(year,01,01), 
                                new DateTime(year,01,02), 
                                new DateTime(year,03,03), 
                                new DateTime(year,06,01), 
                                new DateTime(year,06,06), 
                                new DateTime(year,06,24), 
                                new DateTime(year,09,06), 
                                new DateTime(year,06,22), 
                                new DateTime(year,11,01), 
                                new DateTime(year,12,24), 
                                new DateTime(year,12,25), 
                                new DateTime(year,12,26)
                            };
        DateTime time = DateTime.Now;
        int days = span.Days;
        for (int i = 1; i <= span.Days; i++)
        {
            if (time.AddDays(i).DayOfWeek == DayOfWeek.Saturday || time.AddDays(i).DayOfWeek == DayOfWeek.Sunday)
            {
                --days;
            }
            else
            {
                for (int j = 0; j < holidays.Length; j++)
                {
                    if (time.AddDays(i) == holidays[j])
                    {
                        --days;
                    }
                }
            }
        }
        Console.WriteLine("Work days is: {0}", days);
    }
}
            