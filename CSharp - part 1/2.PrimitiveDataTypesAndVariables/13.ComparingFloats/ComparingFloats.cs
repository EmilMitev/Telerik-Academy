using System;

/*  Problem 13.* Comparing Floats
    Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
    Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature 
    of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely 
    to each other than a fixed constant eps.

 */
public class ComparingFloats
{
    public static void Main()
    {
        Console.WriteLine("Please enter first real number:");
        double firstNumber = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please enter second real number:");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        bool equal = Math.Abs(firstNumber - secondNumber) < 0.000001;
        Console.WriteLine("a == b --> " + equal);
    }
}