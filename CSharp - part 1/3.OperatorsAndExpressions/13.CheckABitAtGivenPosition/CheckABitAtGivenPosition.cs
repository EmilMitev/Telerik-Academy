using System;

/*  Problem 13. Check a Bit at Given Position
    Write a Boolean expression that returns if the bit at position p 
    (counting from 0, starting from the right) in given integer number n, has value of 1.
 */
public class CheckABitAtGivenPosition
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
        bool isOne = bit == 1;
        long binary = long.Parse(Convert.ToString(number, 2));

        Console.WriteLine("Binary representation of number: {0:D16}", binary);
        Console.WriteLine("bit @ position({0}) == 1 : {1} ", position, isOne);
    }
}