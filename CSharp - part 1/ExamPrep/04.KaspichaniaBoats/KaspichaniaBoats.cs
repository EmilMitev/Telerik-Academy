using System;

class KaspichaniaBoats
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = n * 2 + 1;
        int height = 6 + ((n - 3) / 2) * 3;

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (row == n || col == n)
                {
                    Console.Write("*");
                }
                else if (row == height - 1 && col >= height - n && col<= (height -n) + n-2 )
                {

                    Console.Write("*");
                }
                else if (row - col == -n || row + col == n)
                {
                    Console.Write("*");
                }
                else if (row - col == n || row + col == n * 3)
                {
                    Console.Write("*");
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