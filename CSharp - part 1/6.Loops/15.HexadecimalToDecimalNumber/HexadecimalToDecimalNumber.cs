using System;

/*  Problem 15. Hexadecimal to Decimal Number
    Using loops write a program that converts a hexadecimal integer number to its decimal form.
    The input is entered as string. The output should be a variable of type long.
    Do not use the built-in .NET functionality.
 */

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter your hex number: ");
        string hexNumber = Console.ReadLine();
        long number = 0;
        hexNumber = hexNumber.ToUpper();

        for (int i = hexNumber.Length - 1, power = 0; i >= 0; i--, power++)
        {
            char c = hexNumber[i];

            if (c >= 'A' && c <= 'Z')
            {
                int temp = 0;
                switch (c)
                {
                    case 'A': temp = 10; break;
                    case 'B': temp = 11; break;
                    case 'C': temp = 12; break;
                    case 'D': temp = 13; break;
                    case 'E': temp = 14; break;
                    case 'F': temp = 15; break;
                }
                number += temp * (long)Math.Pow(16, power);
            }
            else
            {
                number += Convert.ToInt32(c.ToString()) * (long)Math.Pow(16, power);
            }
        }
        Console.WriteLine("Result in decimal is: " + number);
    }
}