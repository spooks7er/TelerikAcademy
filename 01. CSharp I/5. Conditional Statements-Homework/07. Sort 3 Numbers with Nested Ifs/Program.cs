using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07.Sort_3_Numbers_with_Nested_Ifs
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

                if (a > b)
                {
                    if (a > c)
                    {
                        Console.WriteLine(a);
                    }
                    else
                    {
                        Console.WriteLine(c);
                    }
                }
                else
                {
                    if (b > c)
                    {
                        Console.WriteLine(b);
                    }
                    else
                    {
                        Console.WriteLine(c);
                    }
                }
                if ((b <= a && a <= c) || ((b >= a && a >= c)))
                {
                    Console.WriteLine(a);
                }
                else if ((a <= b && b <= c) || (a >= b && b >= c))
                {
                    Console.WriteLine(b);
                }
                else if ((a <= c && c <= b) || (a >= c && c >= b))
                {
                    Console.WriteLine(c);
                }
                if (a < b)
                {
                    if (a < c)
                    {
                        Console.WriteLine(a);
                    }
                    else
                    {
                        Console.WriteLine(c);
                    }
                }
                else
                {
                    if (b < c)
                    {
                        Console.WriteLine(b);
                    }
                    else
                    {
                        Console.WriteLine(c);
                    }
                }
            }
        }
    }
}
