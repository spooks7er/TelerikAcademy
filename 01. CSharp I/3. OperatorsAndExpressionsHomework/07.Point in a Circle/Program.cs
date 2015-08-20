using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double ox = 0.0;
        double oy = 0.0;
        double r = 2.0;
        Console.WriteLine("Point in a Circle");
        while (true)
        {
            Console.WriteLine("Enter X");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((((x - ox) * (x - ox)) + ((y - oy) * (y - oy))) <= (r * r));
            Console.WriteLine();
        }
    }
}