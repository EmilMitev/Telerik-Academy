using System;
using System.Globalization;
using System.Text.RegularExpressions;

/*  Problem 19. Dates from text in Canada
    Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
    Display them in the standard date format for Canada.
 */

class DatesFromTextInCanada
{
    static void Main()
    {
        string text = "oiinafdafdaspi jfpasd fipadn pda 223.03.2015 fdsa d 02.03 fasfadsf";

        DateTime date;

        foreach (var item in Regex.Matches(text, @"\d+\.\d+\.\d+"))
        {
            try
            {
                string[] dateArr = item.ToString().Split('.');
                date = new DateTime(int.Parse(dateArr[2]), int.Parse(dateArr[1]), int.Parse(dateArr[0]));
                System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
                Console.WriteLine(date);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}