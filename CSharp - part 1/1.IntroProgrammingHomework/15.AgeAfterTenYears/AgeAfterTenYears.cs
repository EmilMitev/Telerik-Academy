using System;

/*  Problem 15.* Age after 10 Years
    Write a program to read your birthday from the console and print 
    how old you are now and how old you will be after 10 years. 
 */
public class AgeAfterTenYears
{
    public static void Main()
    {
        Console.WriteLine("Enter your birthday(DD/MM/YYYY)");
        DateTime myDate = Convert.ToDateTime(Console.ReadLine());
        DateTime today = DateTime.Now;
        int age = 0;

        if (today.Month < myDate.Month)
        {
            age = (DateTime.Now.Year - myDate.Year) - 1;
        }
        else
        {
            if (today.Day > myDate.Day)
            {
                age = (DateTime.Now.Year - myDate.Year) - 1;
            }
            else
            {
                age = DateTime.Now.Year - myDate.Year;
            }
        }

        Console.WriteLine("You are " + age + " years old.");
        Console.WriteLine("After 10 years you will be " + (age + 10) + " years old");
    }
}