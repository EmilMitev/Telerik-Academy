namespace _01.SumAndAverage
{
    using System;
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

            double sum = 0;
            double average = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            average = sum / numbers.Count;

            Console.WriteLine("Sum: {0}, Average: {1}", sum, average);
        }
    }
}
