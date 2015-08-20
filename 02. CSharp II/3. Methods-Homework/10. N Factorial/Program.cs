using System;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine("Factorial of {0} = {1}", i , Factorial(i));
        }
    }

    static BigInteger Factorial(BigInteger i)
    {
        if (i <= 1)
        {
            return 1;
        }
        return i * Factorial(i - 1);
    }
}