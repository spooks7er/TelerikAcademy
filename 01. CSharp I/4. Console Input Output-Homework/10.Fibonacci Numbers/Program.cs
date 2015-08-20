using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        int c = 0;

        Console.WriteLine(a);
        Console.WriteLine(b);
        for (int i = 0; i < n-2; i++)
        {
            c = a + b;
            Console.WriteLine(c);
            a = b;
            b = c;
        }
    }
}