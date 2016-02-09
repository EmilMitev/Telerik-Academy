using System;

class Printing
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long s = long.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());

        long totalSheet = n * s;
        double reams = totalSheet / 500.0;
        double price = reams * p;

        Console.WriteLine("{0:F2}", price);
    }
}