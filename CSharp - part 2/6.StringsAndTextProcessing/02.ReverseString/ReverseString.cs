using System;

/*  Problem 2. Reverse string
    Write a program that reads a string, reverses it and prints the result at the console.
 */

class ReverseString
{
    static void Main()
    {
        string sample = "sample";
        char[] array = sample.ToCharArray();
        Array.Reverse(array);
        sample = string.Join("", array);
        Console.WriteLine(sample);
    }
}