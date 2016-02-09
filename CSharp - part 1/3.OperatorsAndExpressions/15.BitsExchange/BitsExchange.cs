using System;

/*  Problem 15.* Bits Exchange
    Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
 */
public class BitsExchange
{
    public static void Main()
    {
        Console.Write("Enter number: ");
        uint number = uint.Parse(Console.ReadLine());
        uint bits_03_04_05 = number & 0x00000038;
        uint bits_24_25_26 = number & 0x07000000;

        // Cut out "holes" at bits 3, 4, 5, 24, 25, and 26 of the original value
        uint result = (uint) (number & ~(0x00000038 | 0x07000000));

        // Put bits 3, 4, and 5 in place
        result |= bits_03_04_05 << 21;

        // Put bits 23, 24, and 25 in place
        result |= bits_24_25_26 >> 21;

        string binaryNumber = Convert.ToString(number, 2);
        string binaryResult = Convert.ToString(result, 2);

        Console.WriteLine("Your number: {0}", number);
        Console.WriteLine("binary representation of number: {0,32}", binaryNumber);
        Console.WriteLine("Binary result: {0,32}", binaryResult);
        Console.WriteLine("Result: " + result);
    }
}