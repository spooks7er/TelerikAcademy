using System;
//permutations of 1...N
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] c2 = new int[n];
        for (int i = 1; i <= n; i++)
        {
            c2[i - 1] = i;
        }

        Setper(c2);
    }
    private static void swap(ref int a, ref int b)
    {
        if (a == b)
            return;
        a ^= b;
        b ^= a;
        a ^= b;
    }

    public static void Setper(int[] list)
    {
        int x = list.Length - 1;
        Go(list, 0, x);
    }

    private static void Go(int[] list, int k, int m)
    {
        int i;
        if (k == m)
        {
            Console.Write(string.Join(", ", list));
            Console.WriteLine(" ");
        }
        else
        {
            for (i = k; i <= m; i++)
            {
                swap(ref list[k], ref list[i]);
                Go(list, k + 1, m);
                swap(ref list[k], ref list[i]);
            }
        }
    }
}