using System;

class TripleRotationOfDigits
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int tempNumber = 0;
        string result = "";

        if (number < 100)
        {
            tempNumber = number % 10;
            number /= 10;
            if (tempNumber != 0)
            {
                result = tempNumber.ToString() + result;
            }
        }
        else
        {
            for (int i = 0; i < 3; i++)
            {
                tempNumber = number % 10;
                number /= 10;
                if (tempNumber != 0)
                {
                    result = tempNumber.ToString() + result;
                }
            }
        }
        if (number == 0)
        {
            Console.WriteLine(result);
        }
        else if (number != 0)
        {
            Console.WriteLine(result + number.ToString());
        }
    }
}