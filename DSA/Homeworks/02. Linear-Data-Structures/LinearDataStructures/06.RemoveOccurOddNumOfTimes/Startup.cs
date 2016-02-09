namespace _06.RemoveOccurOddNumOfTimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            Console.Write("Enter your numbers:");
            var numbers = Console.ReadLine()
                 .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(n => int.Parse(n))
                 .ToList();

            var dicNumbers = new Dictionary<int, int>();

            foreach (var number in numbers)
            {
                if (!dicNumbers.ContainsKey(number))
                {
                    dicNumbers[number] = 1;
                }
                else
                {
                    dicNumbers[number]++;
                }
            }

            foreach (var item in dicNumbers)
            {
                if (item.Value % 2 != 0)
                {
                    numbers.RemoveAll(n => n == item.Key);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}