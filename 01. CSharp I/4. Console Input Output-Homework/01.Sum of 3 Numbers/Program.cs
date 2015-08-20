using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter first number.");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number.");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number.");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("The result is: {0:0.00}", a + b + c);
    }
}