using System;

/*  Problem 16. Decimal to Hexadecimal Number
    Using loops write a program that converts an integer number to its hexadecimal representation.
    The input is entered as long. The output should be a variable of type string.
    Do not use the built-in .NET functionality.
 */

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        long oneNumber;

        string hexNumber = "";

        do
        {
            oneNumber = number % 16;
            number /= 16;
            if (oneNumber>=10)
            {
                switch (oneNumber)
                {
                    case 10:
                        hexNumber += "A";
                        break;
                    case 11:
                        hexNumber += "B";
                        break;
                    case 12:
                        hexNumber += "C";
                        break;
                    case 13:
                        hexNumber += "D";
                        break;
                    case 14:
                        hexNumber += "E";
                        break;
                    case 15:
                        hexNumber += "F";
                        break;
                    default:
                        break;
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