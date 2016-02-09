namespace _07.NumberOfOccurences
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

            var arrNumbersOccurs = new int[1000];

            foreach (var number in numbers)
            {
                arrNumbersOccurs[number]++;
            }

            for (int i = 0; i < arrNumbersOccurs.Length; i++)
            {
                if (arrNumbersOccurs[i] != 0)
                {
                    Console.WriteLine("{0} -> {1} times.", i, arrNumbersOccurs[i]);
                }
            }
        }
    }
}
