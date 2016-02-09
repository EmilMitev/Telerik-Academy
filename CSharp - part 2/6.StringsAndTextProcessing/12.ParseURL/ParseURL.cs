using System;

/*  Problem 12. Parse URL

    Write a program that parses an URL address given in the format: 
    [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
 */

class ParseURL
{
    static void Main()
    {
        string url = "http://telerikacademy.com/Courses/Courses/Details/212";
        Console.WriteLine("[protocol] = {0}", url.Substring(0, url.IndexOf("://")));
        Console.WriteLine("[server] = {0}", url.Substring(url.IndexOf("://")+3, url.IndexOf(".com")-3));
        Console.WriteLine("[resource] = {0}", url.Substring(url.IndexOf(".com/")+5));
    }
}