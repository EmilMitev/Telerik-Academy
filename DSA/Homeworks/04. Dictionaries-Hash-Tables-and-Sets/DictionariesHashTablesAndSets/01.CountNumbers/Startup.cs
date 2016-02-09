namespace _01.CountNumbers
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var numbers = new List<double>() { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

            var dicNumbers = new SortedDictionary<double, double>();

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
                Console.WriteLine("{0} -> {1} times.", item.Key, item.Value);
            }
        }
    }
}
