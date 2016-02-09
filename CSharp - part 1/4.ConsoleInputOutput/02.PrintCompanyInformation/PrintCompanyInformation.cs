using System;

/*  Problem 2. Print Company Information
    A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
    Write a program that reads the information about a company and its manager and prints it back on the console.
 */
public class PrintCompanyInformation
{
    public static void Main()
    {
        string companyName = "Telerik Academy";
        string companyAddress = "31 Al. Malinov, Sofia";
        string phoneNumber = "+359 888 55 55 555";
        string webSite = "http://telerikacademy.com/";
        string managerFirstName = "Nikolay";
        string managerLastName = "Kostov";
        int managerAge = 25;
        string managerPhone = "+359 2 981 981";

        Console.WriteLine(companyName);
        Console.WriteLine("Adress: " + companyAddress);
        Console.WriteLine("Tel. " + phoneNumber);
        Console.WriteLine("Fax: (no fax)");
        Console.WriteLine("Web site: " + webSite);
        Console.Write("Manager: {0} {1}" , managerFirstName, managerLastName);
        Console.Write("(age: {0}, tel. {1})\n", managerAge, managerPhone);
    }
}