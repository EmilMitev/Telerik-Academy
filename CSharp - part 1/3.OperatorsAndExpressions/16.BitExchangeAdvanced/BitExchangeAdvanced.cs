using System;

/*  Problem 16.** Bit Exchange (Advanced)
    Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
    The first and the second sequence of bits may not overlap.
 */
public class BitExchangeAdvanced
{
    public static void Main()
    {
        Console.Write("Enter number: ");
        uint number = uint.Parse(Console.ReadLine());

        Console.Write("\nEnter p: ");
        byte p = byte.Parse(Console.ReadLine());

        Console.Write("\nEnter q: ");
        byte q = byte.Parse(Console.ReadLine());

        Console.Write("\nEnter k: ");
        byte k = byte.Parse(Console.ReadLine());

        int i = 0;

        int lastSmallBit = (p + k) - 1;
        int lastBigBit = (q + k) - 1;

        int mask;

        long smallBits = 0;
        for (i = p; i <= lastSmallBit; i++)
        {
            mask = 1 << i;
            smallBits |= mask;
        }

        long bigBits = 0;
        for (i = q; i <= lastBigBit; i++)
        {
            mask = 1 << i;
            bigBits |= mask;
        }

        uint smallBits1 = (uint)(number & smallBits);
        uint bigBits1 = (uint)(number & bigBits);

        uint result = (uint)(number & ~(bigBits | smallBits));

        int shift = 0;
        if (lastBigBit > lastSmallBit)
        {
            shift = lastBigBit - lastSmallBit;
            result |= smallBits1 << shift;
            result |= bigBits1 >> shift;
        }
        else
        {
            shift = lastSmallBit - lastBigBit;
            result |= bigBits1 << shift;
            result |= smallBits1 >> shift;
        }

        string binaryNumber = Convert.ToString(number, 2);
        string binaryResult = Convert.ToString(result, 2);

        Console.WriteLine("Binary representation of number: " + binaryNumber);
        Console.WriteLine("Binary result: " + binaryResult);
        Console.WriteLine("Result: " + result);
    }
}