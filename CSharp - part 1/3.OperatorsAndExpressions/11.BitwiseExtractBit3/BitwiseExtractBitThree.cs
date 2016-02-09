using System;

/*  Problem 11. Bitwise: Extract Bit #3
    Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
    The bits are counted from right to left, starting from bit #0.
    The result of the expression should be either 1 or 0.
 */
public class BitwiseExtractBitThree
{
    public static void Main()
    {
        Console.Write("Enter a Number: ");
        int number = int.Parse(Console.ReadLine());

        byte position = 3;
        int mask = 1 << position;
        int nAndMask = number & mask;
        int bit = nAndMask >> position;

        long binary = long.Parse(Convert.ToString(number, 2));

        Console.WriteLine("Binary representation of number: {0:D16}", binary);
        Console.WriteLine("The value of the bit #3 is: " + bit);
    }
}