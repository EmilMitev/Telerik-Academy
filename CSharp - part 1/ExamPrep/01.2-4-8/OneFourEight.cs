using System;

class OneFourEight
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());

        long r = 0;
        long r1 = 0;

        if (b == 2)
        {
            r = a % c;
        }
        else if (b == 4)
        {
            r = a + c;
        }
        else if (b == 8)
        {
            r = a * c;
        }

        if (r % 4 == 0)
        {
            if (r == 4)
            {
                r1 = 1;
                Console.WriteLine(r1);
            }
            else
            {
                r1 = r/4;
                Console.WriteLine(r1);
            }
            Console.WriteLine(r);
        }
        else
        {
            r1 = r % 4;
            Console.WriteLine(r1);
            Console.WriteLine(r);
        }
    }
}