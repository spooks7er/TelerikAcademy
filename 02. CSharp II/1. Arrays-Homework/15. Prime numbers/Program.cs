using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());
        bool[] primes = new bool[n];

        for (int i = 3; i < primes.Length; i++)
        {
            if (i % 2 == 0)
            {
                primes[i]=true;
            }
        }
        for (int i = 4; i < primes.Length; i++)
        {
            if (i % 3 == 0 )
            {
                primes[i] = true;
            }
        }
        for (int i = 6; i < primes.Length; i++)
        {
            if (i % 5 == 0)
            {
                primes[i] = true;
            }
        }
        for (int i = 8; i < primes.Length; i++)
        {
            if (i % 7 == 0)
            {
                primes[i] = true;
            }
        }
        for (int i = 2; i < primes.Length; i++)
        {
            if (primes[i] == false)
            {
                Console.WriteLine(i);
            }
        }
    }
}