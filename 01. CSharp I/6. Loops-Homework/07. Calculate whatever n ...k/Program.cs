using System;
using System.Numerics;
// n! / (k! * (n-k)!) 
//In combinatorics, the number of ways to choose  k  different members out of a group of  n  
//different elements (also known as the number of combinations) is calculated by the following formula: 
//formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//• Your task is to write a program that calculates  n! / (k! * (n-k)!)  for given  
//n  and  k  (1 < k < n < 100). Try to use only two loops.
class Program
{
    static void Main()
    {
        BigInteger n = 0;
        BigInteger k = 0;
        do
        {
            n = BigInteger.Parse(Console.ReadLine());
            k = BigInteger.Parse(Console.ReadLine());
        } while (!(k > 1 && k < n && n < 100));
        double result = (double)Factorial(n) / (double)(Factorial(k) * Factorial(n - k));
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