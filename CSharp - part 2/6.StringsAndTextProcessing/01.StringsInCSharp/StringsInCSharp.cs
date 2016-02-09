using System;

/*  Problem 1. Strings in C#.
    Describe the strings in C#.
    What is typical for the string data type?
    Describe the most important methods of the String class.
 */

class StringsInCSharp
{
    static void Main()
    {
        /*  The strings in C# are primitive referented types, which means that when you implement a string, his value is in the heap,
            Methods of the String Class:
                Equals(string text)
                Equals(string text, StringComparison.CurrentCultureIgnoreCase)
                CompareTo(string text)
                Compare(string text1, string text2, bool isIgnoredCase)
                ToUpper()/ToLower()
                IndexOf(string text)
                LastIndexOf(string text)
                Substring(int index, int length)
                Split(char[] separators, StringSplitoptions.RemoveEmptyEntries)
                Replace(string text1, string text2)
                Regex.Replace(string text, "(string const)[sequence from char to char]{number of elements}", "$1****");
                Trim()
                Trim(char[] symbols)
                TrimEnd()/TrimStart()
                Format("{0}",var)
                type.Parse
            StringBuilder Methods:
                Append(string text)
                ToString()
                Clear()
                Remove(int startIndex, int length)
                Insert(int startIndex, string text)
         */
    }
}