namespace _04.LongestSubsequence
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

            List<int> longestSubsequence = FindLongestSubsequenceOfEqualNumbers(numbers);

            if (longestSubsequence.Count > 0)
            {
                foreach (int number in longestSubsequence)
                {
                    Console.Write("{0} ", number);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No subsequence of equal numbers!");
            }
        }

        private static List<int> FindLongestSubsequenceOfEqualNumbers(List<int> numbers)
        {
            int maxNumber = 0;
            int currentNumber = 0;
            int maxCount = 1;
            int currentCount = 1;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    currentNumber = numbers[i];
                    currentCount++;
                }
                else if (maxCount < currentCount)
                {
                    maxCount = currentCount;
                    maxNumber = currentNumber;
                    currentCount = 1;
                }
            }

            if (maxCount < currentCount)
            {
                maxCount = currentCount;
                maxNumber = currentNumber;
            }

            List<int> longestSequence = new List<int>();
            if (maxCount == 1)
            {
                return longestSequence;
            }

            for (int i = 0; i < maxCount; i++)
            {
                longestSequence.Add(maxNumber);
            }

            return longestSequence;
        }
    }
}