using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _04.Multiplication_Sign
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

                if (a > 0 && b > 0 && c > 0)
                {
                    Console.WriteLine("+");
                }
                else if (a < 0 && b > 0 && c > 0)
                {
                    Console.WriteLine("-");
                }
                else if (a > 0 && b < 0 && c > 0)
                {
                    Console.WriteLine("-");
                }
                else if (a > 0 && b > 0 && c < 0)
                {
                    Console.WriteLine("-");
                }
                else if (a < 0 && b < 0 && c < 0)
                {
                    Console.WriteLine("-");
                }
                else if (a > 0 && b < 0 && c < 0)
                {
                    Console.WriteLine("+");
                }
                else if (a < 0 && b > 0 && c < 0)
                {
                    Console.WriteLine("+");
                }
                else if (a < 0 && b < 0 && c > 0)
                {
                    Console.WriteLine("+");
                }
                else if (a == 0 || b == 0 || c == 0)
                {
                    Console.WriteLine("0");
                }
                
            }
        }
    }
}
