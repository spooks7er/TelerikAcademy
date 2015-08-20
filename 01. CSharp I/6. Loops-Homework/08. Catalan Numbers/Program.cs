using System;
using System.Numerics;
//(2*n)! / (n+1)! * n!
//• In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula 
//• Write a program to calculate the  n  th  Catalan number by given  n  (0 ≤ n ≤ 100). 
class Program
{
    static void Main()
    {
        int n = 0;
        do
        {
            n = int.Parse(Console.ReadLine());
        } while (!(n >= 0 && n <= 100));

        BigInteger catalan = Factorial(2 * n) / (Factorial(n + 1) * Factorial(n));
        Console.WriteLine(catalan);
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