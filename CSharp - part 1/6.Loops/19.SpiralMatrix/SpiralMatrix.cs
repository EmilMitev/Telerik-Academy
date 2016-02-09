using System;

/*  Problem 19.** Spiral Matrix
    Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
    and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.
 */

class SpiralMatrix
{
    static void Main()
    {
        Console.Write("Enter number between 1 and 20: ");
        int number = int.Parse(Console.ReadLine());

        if (1 > number || number > 20)
        {
            Console.WriteLine("You enter wrong number!");
        }
        else
        {
            int count = 1;

            int row = 0;
            int collumn = 0;

            int rememberPointI = 0;
            int rememberPointJ = 0;

            bool isTrue = true;

            int[,] matrix = new int[number, number];

            do
            {
                for (int j = row; j < number; j++)
                {
                    if (count != ((number * number) + 1))
                    {
                        if (matrix[rememberPointI, j] == 0)
                        {
                            matrix[rememberPointI, j] = count;
                            ++count;
                            rememberPointJ = j;
                        }
                    }
                    else
                    {
                        isTrue = false;
                        break;
                    }
                }

                for (int i = collumn; i < number; i++)
                {
                    if (count != ((number * number) + 1))
                    {
                        if (matrix[i, rememberPointJ] == 0)
                        {
                            matrix[i, rememberPointJ] = count;
                            ++count;
                            rememberPointI = i;
                        }
                    }
                    else
                    {
                        isTrue = false;
                        break;
                    }
                }

                for (int j = number - 1; j >= row; j--)
                {
                    if (count != ((number * number) + 1))
                    {
                        if (matrix[rememberPointI, j] == 0)
                        {
                            matrix[rememberPointI, j] = count;
                            ++count;
                            rememberPointJ = j;
                        }
                    }
                    else
                    {
                        isTrue = false;
                        break;
                    }
                }

                for (int i = number - 1; i >= collumn; i--)
                {
                    if (count != ((number * number) + 1))
                    {
                        if (matrix[i, rememberPointJ] == 0)
                        {
                            matrix[i, rememberPointJ] = count;
                            ++count;
                            rememberPointI = i;
                        }
                    }
                    else
                    {
                        isTrue = false;
                        break;
                    }
                }

                ++row;
                ++collumn;

            } while (isTrue);

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.Write("{0,3}", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Nice A?!");
        }
    }
}