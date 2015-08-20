using System;

class Program_old
{
    static void Main_old()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        //biggest
        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
        else
        {
            if (b > c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
        //smallest
        if (a < b)
        {
            if (a < c)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
        else
        {
            if (b < c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
        //mean
        Console.WriteLine("{0:F3}",(double)(a+b+c)/3);
    }
}