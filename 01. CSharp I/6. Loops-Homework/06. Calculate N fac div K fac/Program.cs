using System;
using System.Numerics;
//Write a program that calculates  n! / k!  for given  n  and  k  (1 < k < n < 100).
//• Use only one loop.
class Program
{
    static void Main()
    {
        BigInteger n = 0;
        BigInteger k = 0;
        do
        {
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
        } while (!(k > 1 && k < n && n < 100));
        double result = (double)Factorial(n) / (double)Factorial(k);
        Console.WriteLine(result);
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