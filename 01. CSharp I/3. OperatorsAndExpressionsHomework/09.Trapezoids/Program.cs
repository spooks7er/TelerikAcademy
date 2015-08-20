using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        // Disclaimer, this just calculates the formula, 
        // it does not check if the dimensions correspond to a real trapezoid.
        Console.WriteLine("Enter side a");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side b");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height");
        double h = double.Parse(Console.ReadLine());

        double area = ((a + b) / 2) * h;

        Console.WriteLine("The area of the Trapezoid is {0} sq.cm.", area);
    }
}