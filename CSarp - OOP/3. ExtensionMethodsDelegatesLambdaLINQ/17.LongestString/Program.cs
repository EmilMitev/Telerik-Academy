/*Problem 17
    * Write a program to return the string with maximum length from an array of strings.
    * Use LINQ.
 */
namespace _17.LongestString
{
    using System;
    using System.Linq;

    internal class Program
    {
        private static int maxLength = 0;

        public static int MaxLength
        {
            get
            {
                return maxLength;
            }

            set
            {
                maxLength = value;
            }
        }

        private static void Main()
        {
            var arrayOfStrings = new[] { "dog", "cat", "snake", "chicken", "frog" };
            var longestString =
                from animal in arrayOfStrings
                where GetLongestString(animal)
                select animal;

            Console.WriteLine("Longest string is {0}", longestString.Last());
        }

        private static bool GetLongestString(string s)
        {
            if (s.Length > MaxLength)
            {
                MaxLength = s.Length;
                return true;
            }

            return false;
        }
    }
}