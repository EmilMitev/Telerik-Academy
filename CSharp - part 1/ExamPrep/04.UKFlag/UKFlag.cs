using System;

class UKFlag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (row == n/2 && col ==n/2)
                {
                    Console.Write("*");
                }
                else if (row == n/2)
                {
                    Console.Write("-");
                }
                else if (row + col ==n-1)
                {
                    Console.Write("/");
                }
                else if (row - col == 0)
                {
                    Console.Write("\\");
                }
                else if (col == n/2)
                {
                    Console.Write("|");
                }
                else
                {
                    Console.Write(".");
                }
            }

            Console.WriteLine();
        }
    }
}