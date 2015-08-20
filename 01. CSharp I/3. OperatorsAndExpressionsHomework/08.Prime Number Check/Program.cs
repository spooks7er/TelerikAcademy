using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter a positive whole number:");
            ulong number = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine(isPrime(number));
        }
    }
    public static bool isPrime(ulong number)
    {
        decimal max = Convert.ToDecimal(Math.Sqrt(number));

        if (number == 1) return false;
        if (number == 2) return true;

        for (ulong i = 2; i <= max; ++i)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}