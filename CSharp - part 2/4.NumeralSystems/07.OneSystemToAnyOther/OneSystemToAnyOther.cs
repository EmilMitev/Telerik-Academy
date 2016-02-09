using System;

class OneSystemToAnyOther
{
    static void Main()
    {
        Console.WriteLine("This program convert from S numeral system to D numeral system:");
        Console.Write("Enter s: ");
        int s = int.Parse(Console.ReadLine());

        Console.Write("Enter d: ");
        int d = int.Parse(Console.ReadLine());

        Console.Write("Enter your number: ");
        string number = Console.ReadLine();
        number = number.ToUpper();

        if (s < 2 || d > 16)
        {
            Console.WriteLine("Wron numeral system!");
            return;
        }
        if (checkNumber(number, s))
        {
            return;
        }

        Console.WriteLine("The number {0} from {1} numeral system to {2} numeral system is: {3}", number, s, d, FromDec(ToDec(number, s), d));
    }

    static long ToDec(string anySystemNumber, int s)
    {
        long number = 0;
        anySystemNumber = anySystemNumber.ToUpper();

        for (int i = anySystemNumber.Length - 1, power = 0; i >= 0; i--, power++)
        {
            char c = anySystemNumber[i];

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
                number += temp * (long)Math.Pow(s, power);
            }
            else
            {
                number += Convert.ToInt32(c.ToString()) * (long)Math.Pow(s, power);
            }
        }
        return number;
    }

    static string FromDec(long number, int d)
    {
        long oneNumber;
        string anySystemNumber = "";
        do
        {
            oneNumber = number % d;
            number /= d;
            if (oneNumber >= 10)
            {
                switch (oneNumber)
                {
                    case 10: anySystemNumber = "A" + anySystemNumber; break;
                    case 11: anySystemNumber = "B" + anySystemNumber; break;
                    case 12: anySystemNumber = "C" + anySystemNumber; break;
                    case 13: anySystemNumber = "D" + anySystemNumber; break;
                    case 14: anySystemNumber = "E" + anySystemNumber; break;
                    case 15: anySystemNumber = "F" + anySystemNumber; break;
                    default: break;
                }
            }
            else
            {
                anySystemNumber = oneNumber + anySystemNumber;
            }
        } while (number != 0);

        return anySystemNumber;
    }

    static bool checkNumber(string number, int s)
    {
        for (int i = 0; i < number.Length; i++)
        {
            char c = number[i];

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
                if (temp >= s)
                {
                    Console.WriteLine("You enter a wrong number for {0} numeral system!", s);
                    return true;
                }
            }
            else
            {
                if (Convert.ToInt32(c.ToString()) >= s)
                {
                    Console.WriteLine("You enter a wrong number for {0} numeral system!", s);
                    return true;
                }
            }
        }
        return false;
    }
}
