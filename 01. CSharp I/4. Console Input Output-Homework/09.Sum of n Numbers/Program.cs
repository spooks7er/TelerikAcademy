using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        int a = int.Parse(Console.ReadLine());

        double sum = 0;

        for (int i = 1; i < a + 1; i++)
        {
            Console.WriteLine("Enter another number");
            double n = double.Parse(Console.ReadLine());
            sum += n;
        }
        Console.WriteLine("The result is:");
        Console.WriteLine(sum);
    }
}