using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06.The_Biggest_of_Five_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            while (true)
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                double d = double.Parse(Console.ReadLine());
                double e = double.Parse(Console.ReadLine());

                if (a > b && a > c && a > d && a > e)
                {
                    Console.WriteLine("biggest " + a);
                }
                else if (b >= a && b >= c && b >= d && b >= e)
                {
                    Console.WriteLine("biggest " + b);
                }
                else if (c >= a && c >= b && c >= d && c >= e)
                {
                    Console.WriteLine("biggest " + c);
                }
                else if (d >= a && d >= b && d >= c && d >= e)
                {
                    Console.WriteLine("biggest " + d);
                }
                else if (e >= a && e >= b && e >= c && e >= d)
                {
                    Console.WriteLine("biggest " + e);
                }
            }
        }
    }
}
