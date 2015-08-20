using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double moonGravRatio = 0.17;

        while (true)
        {
            Console.WriteLine("Enter your weight.");
            double weight = double.Parse(Console.ReadLine());
            double result = weight * moonGravRatio;
            Console.WriteLine("Your weight on the Moon will be: {0} kg.", result);
        }
    }
}