using System;
using System.Globalization;
using System.Threading;

/*  Problem 10.* Beer Time
    A beer time is after 1:00 PM and before 3:00 AM.
    Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], 
    a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer 
    7time according to the definition above or invalid time if the time cannot be parsed. 
    Note: You may need to learn how to parse dates and times.
 */

class BeerTime
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        try
        {
            Console.WriteLine("Enter time (hh:mm tt):");
            string dateTime = Console.ReadLine();
            DateTime time = DateTime.Parse(dateTime);
            Console.WriteLine(time.TimeOfDay.Hours);

            if (time.TimeOfDay.Hours >= 13 && time.TimeOfDay.Hours <= 23)
            {
                Console.WriteLine("Result: BEER TIME!");
            }
            else if (time.TimeOfDay.Hours >= 0 && time.TimeOfDay.Hours < 3)
            {
                Console.WriteLine("Result: BEER TIME!");
            }
            else
            {
                Console.WriteLine("Result: non-beer time :(");
            }
        }
        catch (System.FormatException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Invalid time!!!");
        }
    }
}