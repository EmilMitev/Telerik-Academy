using System;

class BinaryShort
{
    static void Main()
    {
        Console.Write("Enter a number in interval [{0}; {1}]: ", short.MinValue, short.MaxValue);
        short number = short.Parse(Console.ReadLine());

        Console.WriteLine("{0} to binary = {1}", number, ToBinary(number));
    }

    static string ToBinary(int number)
    {
        string binNumber = "";
        for (int i = 15; i >= 0; i--)
        {
            binNumber = ((number % 2) & 1) + binNumber;
            number >>= 1;
        }
        return binNumber;
    }
}