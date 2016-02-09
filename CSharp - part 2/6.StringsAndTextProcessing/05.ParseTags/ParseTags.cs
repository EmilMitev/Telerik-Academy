using System;
using System.Text.RegularExpressions;

/*  Problem 5. Parse tags
    You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
    The tags cannot be nested.
    Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
    The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
 */

class ParseTags
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

        //Console.WriteLine(Regex.Replace(text, "<upcase>(.*?)</upcase>", word => word.Groups[1].Value.ToUpper()));

        int first = 0;
        int last = 0;

        while (true)
        {
            first = text.IndexOf("<upcase>");
            last = text.IndexOf("</upcase>");

            if (first == -1 || last == -1)
            {
                break;
            }

            string oldText = text.Substring(first, last - first + 9);
            string temp = text.Substring(first + 8, last - first - 8).ToUpper();
            text = text.Replace(oldText, temp);
        }

        Console.WriteLine(text);
    }
}