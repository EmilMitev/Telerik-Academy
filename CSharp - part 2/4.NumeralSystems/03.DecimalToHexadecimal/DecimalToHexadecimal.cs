using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter number in decimal: ");
        long number = long.Parse(Console.ReadLine());

        DecToHex(number);
    }

    static void DecToHex(long number)
    {
        long oneNumber;
        string hexNumber = "";
        do
        {
            oneNumber = number % 16;
            number /= 16;
            if (oneNumber >= 10)
            {
                switch (oneNumber)
                {
                    case 10: hexNumber += "A"; break;
                    case 11: hexNumber += "B"; break;
                    case 12: hexNumber += "C"; break;
                    case 13: hexNumber += "D"; break;
                    case 14: hexNumber += "E"; break;
                    case 15: hexNumber += "F"; break;
                    default: break;
                }
            }
            else
            {
                hexNumber += oneNumber;
            }
        } while (number != 0);

        for (int i = hexNumber.Length - 1; i >= 0; i--)
        {
            Console.Write(hexNumber[i]);
        }
        Console.WriteLine();
    }
}