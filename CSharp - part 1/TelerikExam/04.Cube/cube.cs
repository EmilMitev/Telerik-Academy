using System;

class cube
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string str =
            new string(' ', n - 1) +
            new string(':', n);

        Console.WriteLine(str);

        int j = 2;

        for (int i = 0; i < n - 2; i++)
        {
            string str1 =
                new string(' ', n - j) +
                ":" +
                new string('/', n - 2) +
                ":" +
                new string('X', i) +
                ":";
            ++j;
            Console.WriteLine(str1);
        }

        string str2 =
            new string(':', n) +
            new string('X', n - 2) +
            ":";
        Console.WriteLine(str2);

        for (int i = 0; i < n - 2; i++)
        {
            string str3 =
                ":" +
                new string(' ', n - 2) +
                ":" +
                new string('X', n - (3 + i)) +
                ":";
            Console.WriteLine(str3);
        }

        string str4 =
            new string(':', n);
        Console.WriteLine(str4);
    }
}