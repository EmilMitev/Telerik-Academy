using System;

/*  Problem 12. Extract Bit from Integer
    Write an expression that extracts from given integer n the value of given bit at index p.
 */
public class ExtractBitFromInteger
{
    public static void Main()
    {
        Console.Write("Enter a Number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("\nEnter a position: ");
        byte position = byte.Parse(Console.ReadLine());

        int mask = 1 << position;
        int nAndMask = number & mask;
        int bit = nAndMask >> position;

        long binary = long.Parse(Convert.ToString(number, 2));

        Console.WriteLine("Binary representation of number: {0:D16}", binary);
        Console.WriteLine("bit @ position {0}: {1} ", position, bit);
    }
}