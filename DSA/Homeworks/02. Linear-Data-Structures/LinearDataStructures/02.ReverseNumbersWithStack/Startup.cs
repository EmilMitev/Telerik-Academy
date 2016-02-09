namespace _02.ReverseNumbersWithStack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            Console.Write("Enter your numbers: ");
            var numbersAsList = Console.ReadLine()
                  .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                  .Select(n => int.Parse(n))
                  .ToList();

            var numbers = new Stack<int>();

            foreach (var number in numbersAsList)
            {
                numbers.Push(number);
            }

            while (numbers.Count > 0)
            {
                Console.Write(numbers.Pop() + " ");
            }
            Console.WriteLine();
        }
    }
}
