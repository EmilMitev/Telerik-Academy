using System;

class DrunkenNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        long drinkV = 0;
        long drinkM = 0;

        for (int i = 0; i < n; i++)
        {
            long number = long.Parse(Console.ReadLine());
            number = Math.Abs(number);
            string str = number.ToString();

            if (str.Length % 2 == 0)
            {
                for (int j = 1; j <= str.Length/ 2; j++)
                {
                    drinkV += number % 10;
                    number /= 10;
                }

                for (int k = str.Length / 2+1; k <= str.Length; k++)
                {
                    drinkM += number % 10;
                    number /= 10;
                }
            }
            else
            {
                for (int j = 1; j <= str.Length / 2; j++)
                {
                    drinkV += number % 10;
                    number /= 10;
                }

                long temp = number % 10;
                drinkM += temp;
                drinkV += temp;
                number /= 10;
                for (int k = str.Length / 2 +1 ; k <= str.Length; k++)
                {
                    drinkM += number % 10;
                    number /= 10;
                }
            }
        }
        if (drinkV > drinkM)
        {
            Console.WriteLine("V {0}", drinkV - drinkM);
        }
        else if (drinkV < drinkM)
        {
            Console.WriteLine("M {0}", drinkM -drinkV);
        }
        else
        {
            Console.WriteLine("No {0}", drinkM + drinkV);
        }
    }
}