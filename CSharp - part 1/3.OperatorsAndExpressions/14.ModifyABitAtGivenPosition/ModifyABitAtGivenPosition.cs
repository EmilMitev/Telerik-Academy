using System;

/*  Problem 14. Modify a Bit at Given Position
    We are given an integer number n, a bit value v (v=0 or 1) and a position p.
    Write a sequence of operators (a few lines of C# code) that modifies n to 
    hold the value v at the position p from the binary representation of n while preserving all other bits in n.
 */
public class ModifyABitAtGivenPosition
{
    public static void Main()
    {
        Console.Write("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        Console.Write("\nEnter a position:");
        byte position = byte.Parse(Console.ReadLine());

        Console.Write("\nEnter a bit value(0 or 1):");
        byte bitValue = byte.Parse(Console.ReadLine());

        int result = 0;
        int mask = 0;

        if (bitValue == 1)
        {
            mask = 1 << position;
            result = number | mask;
        }
        else if (bitValue == 0)
        {
            mask = 1 << position;
            result = number & ~mask;
        }
        else
        {
            Console.WriteLine("WRONG bit value!!!!");
        }

        long binary = long.Parse(Convert.ToString(number, 2));
        long binaryResult = long.Parse(Convert.ToString(result, 2));

        Console.WriteLine("Binary representation of number: {0:D16}", binary);
        Console.WriteLine("Binary result: {0:D16}", binaryResult);
        Console.WriteLine("Result: " + result);
    }
}