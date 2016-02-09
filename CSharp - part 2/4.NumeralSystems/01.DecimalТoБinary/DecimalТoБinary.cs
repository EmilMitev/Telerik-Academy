using System;

class DecimalТoБinary
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        int decNumber = int.Parse(Console.ReadLine());
        DecToBin(decNumber);
    }

    static void DecToBin(int decNumber)
    {
        string binnaryNumber = "";
        do
        {
            if (decNumber % 2 == 0)
            {
                binnaryNumber += "0";
            }
            else
            {
                binnaryNumber += "1";
            }
            decNumber /= 2;

        } while (decNumber != 0);

        Console.Write("Binary representation on your number is: ");
        for (int i = binnaryNumber.Length - 1; i >= 0; i--)
        {
            Console.Write(binnaryNumber[i]);
        }
        Console.WriteLine();
    }
}