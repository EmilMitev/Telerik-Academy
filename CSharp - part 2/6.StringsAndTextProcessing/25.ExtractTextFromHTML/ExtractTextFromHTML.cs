﻿using System;
using System.Text.RegularExpressions;

/*Problem 25. Extract text from HTML

Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
Example input:

<html>
  <head><title>News</title></head>
  <body><p><a href="http://academy.telerik.com">Telerik
    Academy</a>aims to provide free real-world practical
    training for young people who want to turn into
    skilful .NET software engineers.</p></body>
</html>
Output:

Title: News

Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.
 */

class ExtractTextFromHTML
{
    static void Main()
    {
        string text = "<html>" +
                            "<head><title>News</title></head>" +
                            "<body><p><a href=\"http://academy.telerik.com\">Telerik " +
                                "Academy</a>aims to provide free real-world practical " +
                                "training for young people who want to turn into " +
                                "skilful .NET software engineers." +
                            "</p></body>" +
                       "</html>";

        Console.WriteLine("Title: {0}", Regex.Replace(Regex.Match(text, "<title>+\\w+</title>").ToString(), "<title>(.*?)</title>", word => word.Groups[1].Value));
        text = text.Substring(text.IndexOf("<body>"), text.IndexOf("</body>") - text.IndexOf("<body>"));
        Console.WriteLine("Text: {0}", Regex.Replace(text, "(?s)<.*?>", " ").Trim());

    }
}