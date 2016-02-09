/* Problem 2.
    * Implement a set of extension methods for IEnumerable<T> that implement the following group
    * functions: sum, product, min, max, average.
 */
namespace _02.IEnumerableExtension
{
    using System;
    using System.Collections.Generic;

    public static class TestExtension
    {
        private static void Main()
        {
            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine("Sum = {0} ", list.SumElements<int>());
            Console.WriteLine("Product = {0} ", list.ProductElements<int>());
            Console.WriteLine("Min = {0} ", list.MinElement<int>());
            Console.WriteLine("Max = {0} ", list.MinElement<int>());
            Console.WriteLine("Average = {0} ", list.AverageCol<int>());

            Console.WriteLine(new string('*', 30));

            IEnumerable<double> array = new[] { 1.2, 3.4, 5.6 };

            Console.WriteLine("Sum = {0} ", array.SumElements<double>());
            Console.WriteLine("Product = {0:F2} ", array.ProductElements<double>());
            Console.WriteLine("Min = {0} ", array.MinElement<double>());
            Console.WriteLine("Max = {0} ", array.MaxElement<double>());
            Console.WriteLine("Average = {0} ", array.AverageCol<double>());
        }
    }
}
