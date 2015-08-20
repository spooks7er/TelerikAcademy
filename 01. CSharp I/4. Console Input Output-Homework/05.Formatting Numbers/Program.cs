using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        
        //Console.WriteLine("Enter an integer, it must be 0 <= a <= 500");
        //int a = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter a floating point number.");
        //double b = double.Parse(Console.ReadLine());
        //Console.WriteLine("Enter a floating point number.");
        //double c = double.Parse(Console.ReadLine());

        int a = 499;
        double b = -0.5559;
        double c = 10000;

        if (a >= 0 && a <= 500)
        {
            Console.WriteLine("{0}|{1}|{2:F2}|{3:F3}|", Convert.ToString(a, 16).PadRight(10, ' '), Convert.ToString(a, 2).PadLeft(10, '0'), Convert.ToString(b).PadRight(10, ' '), Convert.ToString(c).PadLeft(10, ' '));
        }
        else
        {
            Console.WriteLine("The first number must be 0 <= a <= 500");
        }
    }
}