using System;

public class Task1
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine(FindBiggest(a, b, c));
        Console.WriteLine(FindSmallest(a, b, c));
        Console.WriteLine("{0:F3}", FindMean(a, b, c));
    }

    private static int FindBiggest(int a, int b, int c)
    {
        if (a > b)
        {
            if (a > c)
            {
                return a;
            }
        }

        if (b > c)
        {
            return b;
        }

        return c;
    }

    private static int FindSmallest(int a, int b, int c)
    {
        if (a < b)
        {
            if (a < c)
            {
                return a;
            }
        }

        if (b < c)
        {
            return b;
        }

        return c;
    }

    private static double FindMean(int a, int b, int c)
    {
        double mean = (double)(a + b + c) / 3;

        return mean;
    }
}