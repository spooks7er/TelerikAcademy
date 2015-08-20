using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter a.");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter b.");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter c.");
        double c = double.Parse(Console.ReadLine());

        double d = b * b - 4 * a * c;

        if (d > 0)
        {
            double x1 = ((-b) - Math.Sqrt(d)) / (2 * a);
            double x2 = ((-b) + Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("The real roots are {0} and {1}", x1, x2);
        }
        else if (d < 0)
        {
            Console.WriteLine("The equation has no real roots.");
        }
        else if (d == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("The only real root is {0}.", x);
        }
    }
}