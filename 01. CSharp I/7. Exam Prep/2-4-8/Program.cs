using System;

class Program
{
    static void Main()
    {
        long a = int.Parse(Console.ReadLine());
        long b = int.Parse(Console.ReadLine());
        long c = int.Parse(Console.ReadLine());

        long r = 0;
        long res = 0;

        if (b == 2)
        {
            r = a % c;
        }
        if (b == 4)
        {
            r = a + c;
        }
        if (b == 8)
        {
            r = a * c;
        }

        if (r % 4 == 0)
        {
            res = r / 4;
            Console.WriteLine(res);
            Console.WriteLine(r);
        }
        else
        {
            res = r % 4;
            Console.WriteLine(res);
            Console.WriteLine(r);
        }
    }
}