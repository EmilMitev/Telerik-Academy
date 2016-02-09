namespace _02.IEnumerableExtension
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Extention
    {
        public static T SumElements<T>(this IEnumerable<T> collection)
                    where T : IComparable
        {
            dynamic sum = 0;

            foreach (var item in collection)
            {
                sum += item;
            }

            return sum;
        }

        public static T ProductElements<T>(this IEnumerable<T> collection)
                    where T : IComparable
        {
            dynamic prod = 1;

            foreach (var item in collection)
            {
                prod *= item;
            }

            return prod;
        }

        public static T MinElement<T>(this IEnumerable<T> collection)
                    where T : IComparable
        {
            T min = collection.FirstOrDefault();

            foreach (var item in collection)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T MaxElement<T>(this IEnumerable<T> collection)
                   where T : IComparable
        {
            T max = collection.FirstOrDefault();

            foreach (var item in collection)
            {
                if (max.CompareTo(item) < 0)
                {
                    max = item;
                }
            }

            return max;
        }

        public static T AverageCol<T>(this IEnumerable<T> collection)
                   where T : IComparable
        {
            dynamic average = 0;
            dynamic sum = 0;
            int count = 0;

            foreach (var item in collection)
            {
                sum += item;
                count++;
            }

            average = sum / count;
            return average;
        }
    }
}
