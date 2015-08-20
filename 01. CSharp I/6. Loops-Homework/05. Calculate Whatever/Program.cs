using System;
using System.Numerics;
//Write a program that, for a given two integer numbers  n  and  x , 
//calculates the sum  S = 1 + 1!/x + 2!/x2 + … + n!/x^n .
//• Use only one loop. Print the result with  5  digits after the decimal point.
class Program
{
    static void Main()
    {
        BigInteger n = int.Parse(Console.ReadLine());
        double x = int.Parse(Console.ReadLine());
        double sum = 1;
        for (BigInteger i = 1; i <= n; i++)
        {
            sum += (double)Factorial(i) / Math.Pow(x, (double)i);
        }
        Console.WriteLine("{0:F5}", sum);
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