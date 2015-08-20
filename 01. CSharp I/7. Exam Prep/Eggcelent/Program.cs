using System;
//.....***.....
//...*.....*...
//.*.........*.//
//.*@.@.@.@.@*.//
//.*.@.@.@.@.*.//
//.*.........*.//
//...*.....*...
//.....***.....

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //int n = 26;
        int h = 2 * n;
        int w = 3 * n - 1;
        int wd = 3 * n + 1;
        int top = n - 1;
        int bot = n - 1;


        Console.WriteLine(new string('.', n + 1) + new string('*', n - 1) + new string('.', n + 1));

        if (n != 2)
        {

            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine(new string('.', (n + 1) - i * 2) + '*' + new string('.', (n + (i * 4)) - 3) + '*' + new string('.', (n + 1) - i * 2));
            }
        }
        if (n != 2)
        {
            for (int i = 0; i < (n / 2) - 2; i++)
            {
                Console.WriteLine("." + "*" + new string('.', (n * 3) - 3) + "*" + ".");
            }
        }

        Console.Write("." + "*" + "@.");
        for (int i = 1; i <= (wd - 7) / 2; i++)
        {
            Console.Write("@.");
        }
        Console.WriteLine("@" + "*" + ".");

        Console.Write("." + "*" + ".");
        for (int i = 1; i <= (wd - 7) / 2; i++)
        {
            Console.Write("@.");
        }
        Console.WriteLine("@." + "*" + ".");

        if (n != 2)
        {
            for (int i = 0; i < (n / 2) - 2; i++)
            {
                Console.WriteLine("."+"*" + new string('.', (n * 3) - 3) + "*"+".");

            }
        }
        if (n != 2)
        {
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine(new string('.', ((n - (n - i + 2)) + (i + 1))) + '*' + new string('.', (3 * n - 1) - ((i * 4) - 2)) + '*' + new string('.', ((n - (n - i + 2)) + (i + 1))));
            }
        }
        Console.WriteLine(new string('.', n + 1) + new string('*', n - 1) + new string('.', n + 1));
    }
}