namespace _03.SortList
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

            numbers.Sort();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
