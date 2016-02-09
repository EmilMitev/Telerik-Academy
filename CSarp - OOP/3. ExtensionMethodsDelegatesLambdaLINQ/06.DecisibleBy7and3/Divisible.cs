/* Problem 6.
    * Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension
    * methods and lambda expressions. Rewrite the same with LINQ.
 */
namespace _06.DecisibleBy7and3
{
    using System;
    using System.Linq;

    internal class Divisible
    {
        private static void Main()
        {
            var arrayOfInt = new[] { 3, 4, 23, 24, 56, 4, 5, 89, 0, -12, 8, 14, 28, 63 };

            var divisible = arrayOfInt
                .Where(x => x % 3 == 0 && x % 7 == 0);

            Console.WriteLine("Using lambda:");
            foreach (var item in divisible)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();

            var divisibleLinq =
                from n in arrayOfInt
                where n % 3 == 0 && n % 7 == 0
                select n;
            Console.WriteLine("Using LINQ:");
            foreach (var item in divisibleLinq)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();
        }
    }
}