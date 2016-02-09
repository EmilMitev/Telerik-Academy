using System;
using System.Numerics;

class SaddyKopper
{
    static void Main()
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());

        if (number < 0)
        {
            number *= -1;
        }

        long result = 0;
        BigInteger product = 1;

        byte transformation = 0;
        do
        {
            do
            {
                number /= 10;
                string num = number.ToString();

                for (int i = num.Length - 1; i >= 0; i--)
                {
                    if (i % 2 == 0)
                    {
                        result += Convert.ToInt64(num[i].ToString());
                    }
                }

                product *= (BigInteger)result;
                result = 0;
            } while (number >= 10);

            ++transformation;
            number = product;
            product = 1;

            if (number < 10)
            {
                Console.WriteLine(transformation);
                Console.WriteLine(number);
                break;
            }
            else if (transformation >= 10)
            {
                Console.WriteLine(number);
                break;
            }
        } while (true);
    }
}