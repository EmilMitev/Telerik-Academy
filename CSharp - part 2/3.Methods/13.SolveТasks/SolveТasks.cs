using System;

/*  Problem 13. Solve tasks
    Write a program that can solve these tasks:
        Reverses the digits of a number
        Calculates the average of a sequence of integers
        Solves a linear equation a * x + b = 0
    Create appropriate methods.
    Provide a simple text-based menu for the user to choose which task to solve.
    Validate the input data:
        The decimal number should be non-negative
        The sequence should not be empty
        a should not be equal to 0
 */

class SolveТasks
{
    static void Main()
    {
        do
        {
            Console.WriteLine("*-----------------------------------------------------*");
            Console.WriteLine("1.Reverses the digits of a number.");
            Console.WriteLine("2.Calculates the average of a sequence of integers.");
            Console.WriteLine("3.Solves a linear equation a * x + b = 0");
            Console.WriteLine("4.Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter number to reverse: ");
                    int number = int.Parse(Console.ReadLine());
                    if (number >= 0)
                    {
                        Console.WriteLine("Reverse number is: {0}", ReverseNumber(number));
                    }
                    else
                    {
                        Console.WriteLine("You enter a wrong number!");
                    }

                    break;
                case 2:
                    Console.Write("How many number you want? - ");
                    int n = int.Parse(Console.ReadLine());
                    if (n != 0)
                    {
                        int[] numbers = new int[n];
                        for (int i = 0; i < n; i++)
                        {
                            numbers[i] = int.Parse(Console.ReadLine());
                        }
                        Average(numbers);
                    }
                    else
                    {
                        Console.WriteLine("You should have 1 number less!");
                    }
                    break;
                case 3:
                    Console.Write("Enter a: ");
                    int a = int.Parse(Console.ReadLine());
                    if (a != 0)
                    {
                        Console.Write("Enter b: ");
                        int b = int.Parse(Console.ReadLine());
                        SolvesLinearEquation(a, b);
                    }
                    else
                    {
                        Console.WriteLine("a should be a!=0 !");
                    }
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
        } while (true);

    }

    static string ReverseNumber(int number)
    {
        int temp = 0;
        string reverseNumber = "";
        while (number != 0)
        {
            temp = number % 10;
            reverseNumber += temp.ToString();
            number /= 10;
        }
        return reverseNumber;
    }

    static void Average(int[] numbers)
    {
        double average = 0;
        Console.Write("Average sum of: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            average += numbers[i];
            Console.Write(" {0} ", numbers[i]);
        }
        average = average / numbers.Length;
        Console.Write("is: {0:0.00}", average);
        Console.WriteLine();
    }

    static void SolvesLinearEquation(int a, int b)
    {
        double x;
        x = -(b / (double)a);
        Console.WriteLine("x = {0}", x);
    }
}