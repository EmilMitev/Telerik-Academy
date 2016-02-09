using System;
using System.Globalization;
using System.Threading;

/*  Problem 4. Number Comparer
    Write a program that gets two numbers from the console and prints the greater of them.
    Try to implement this without if statements.
 */
public class NumberComparer
{
    public static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter first number: ");
        float firstNumber = float.Parse(Console.ReadLine().Replace(',', '.'));

        Console.Write("Enter second number: ");
        float secondNumber = float.Parse(Console.ReadLine().Replace(',', '.'));

        Console.WriteLine(firstNumber > secondNumber ? "{0} is greater" : "{1} is greater", firstNumber, secondNumber);
    }
}