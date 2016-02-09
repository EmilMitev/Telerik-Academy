namespace _02.OddNumberOfTimes
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        static void Main()
        {
            var strings = new List<string>() { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            var dicNumbers = new Dictionary<string, int>();

            foreach (var str in strings)
            {
                if (!dicNumbers.ContainsKey(str))
                {
                    dicNumbers[str] = 1;
                }
                else
                {
                    dicNumbers[str]++;
                }
            }

            foreach (var item in dicNumbers)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write(item.Key + " ");
                }
            }
            
            Console.WriteLine();
        }
    }
}

