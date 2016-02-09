using System;

class NightmareOnCodeStreet
{
    static void Main()
    {
        string input = Console.ReadLine();

        long count = 0;
        long sum = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (i % 2 != 0 && char.IsDigit(input[i]))
            {
                ++count;
                sum += input[i];
            }
        }

        Console.WriteLine("{0} {1}", count, sum-count*48);
    }
}