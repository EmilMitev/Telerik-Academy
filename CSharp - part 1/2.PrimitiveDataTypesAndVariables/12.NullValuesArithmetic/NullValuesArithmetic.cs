using System;

/*  Problem 12. Null Values Arithmetic
    Create a program that assigns null values to an integer and to a double variable.
    Try to print these variables at the console.
    Try to add some number or the null literal to these variables and print the result.
 */

public class NullValuesArithmetic
{
    public static void Main()
    {
        int? someInt = null;
        double? someDouble = null;

        Console.WriteLine("This is null int with null value:" + someInt);
        Console.WriteLine("This is null double with null value:" + someDouble);
        Console.WriteLine("Add some number to int:" + (someInt + 10));
        Console.WriteLine("Add some number to double:"+ (someDouble + 5.144));
    }
}