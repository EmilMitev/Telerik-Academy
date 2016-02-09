using System;
using System.Threading;
using System.Globalization;

/*  Problem 9. Play with Int, Double and String
    Write a program that, depending on the user’s choice, inputs an int, double or string variable.
    If the variable is int or double, the program increases it by one.
    If the variable is a string, the program appends * at the end.
    Print the result at the console. Use switch statement.
 */

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("1-->int");
        Console.WriteLine("2-->double");
        Console.WriteLine("3-->string");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Write("Enter an integer:");
                int intNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Result: " + (intNumber + 1));
                break;
            case "2":
                Console.Write("Enter a double: ");
                double doubleNumber = double.Parse(Console.ReadLine().Replace(',', '.'));
                Console.WriteLine("Result: " + (doubleNumber + 1));
                break;
            case "3":
                Console.Write("Enter a string: ");
                string str = Console.ReadLine();
                Console.WriteLine("Result: {0}*", str);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}