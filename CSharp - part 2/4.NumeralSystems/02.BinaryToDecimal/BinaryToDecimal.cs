using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter your binnary number: ");
        string binaryNumber = Console.ReadLine();
        BinToDec(binaryNumber);
    }

    static void BinToDec(string binaryNumber)
    {
        long result = 0;
        char digit;
        int power = 0;

        for (int i = binaryNumber.Length - 1; i >= 0; i--)
        {
            digit = binaryNumber[i];
            if (digit == '1')
            {
                result += (long)Math.Pow(2, power);
            }
            ++power;
        }
        Console.WriteLine("Result is: " + result);
    }
}