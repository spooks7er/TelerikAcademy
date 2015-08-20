using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InstalledUICulture;

        double ox = 1.0;
        double oy = 1.0;
        double r = 1.5;
        Console.WriteLine("Point In a Circle and Out of a Rectangle");
        while (true)
        {
            Console.WriteLine("Enter X");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(
                (((x - ox) * (x - ox)) + ((y - oy) * (y - oy))) <= (r * r)
                &&
                (x > 5 || x < -1 || y < -1 || y > 1)
                );
            Console.WriteLine();
        }
    }
}