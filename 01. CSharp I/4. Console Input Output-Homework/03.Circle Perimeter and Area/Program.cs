using System;
using System.Globalization;
using System.Threading;

class Program
{
    const double _PI = 3.14159265359;
    
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter the Radius.");
        double r = double.Parse(Console.ReadLine());

        double perimeter = 2 * _PI * r;
        double area = _PI * r * r;

        Console.WriteLine("The perimeter of the circle is {0:0.00}\nthe Area of the circle is {1:0.00}.", perimeter, area);
    }
}