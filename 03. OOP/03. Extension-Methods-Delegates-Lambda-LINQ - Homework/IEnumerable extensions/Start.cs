using System;
using System.Linq;

namespace Ex2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] list = { 1, 12, 3 };
            double s = list.AvgValue();

            Console.WriteLine(list.Sum());
            Console.WriteLine(list.Product());
            Console.WriteLine(list.MinValue());
            Console.WriteLine(list.Max());
            Console.WriteLine(list.AvgValue());
        }
    }
}