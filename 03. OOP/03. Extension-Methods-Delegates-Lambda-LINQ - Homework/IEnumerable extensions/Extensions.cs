using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex2
{
    public static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            dynamic result = 0;

            foreach (var item in collection)
            {
                result += item;
            }

            return result;
        }

        public static T Product<T>(this IEnumerable<T> collection)
        {
            dynamic result = 1;

            foreach (var item in collection)
            {
                result *= item;
            }

            return result;
        }

        public static T MinValue<T>(this IEnumerable<T> collection)
        {
            return collection.Min();
        }

        public static T MaxValue<T>(this IEnumerable<T> collection)
        {
            return collection.Max();
        }

        public static double AvgValue<T>(this IEnumerable<T> collection)
        {
            double sum = 0.0;
            return (dynamic)collection.Aggregate(sum, (acc, val) => acc + (dynamic)val) / (dynamic)collection.Count();
        }
    }
}
