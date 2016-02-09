using System;
using System.Text.RegularExpressions;

/*  Problem 18. Extract e-mail
    Write a program for extracting all email addresses from given text.
    All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
 */

class ExtractEmails
{
    static void Main()
    {
        string text = "Contact Telerik at telerik@telerik.com or nakov@gmail.com";

        foreach (var item in Regex.Matches(text, @"\w+@\w+\.\w+"))
        {
            Console.WriteLine(item);
        }
    }
}