using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a sequence of integers separated by space");
        string seq = Console.ReadLine();
        string[] array = seq.Split(' ');

        //string[] array = { "1", "2", "3", "4", "5" };
        Console.WriteLine(FindMax(array));
        Console.WriteLine(FindMin(array));
        Console.WriteLine(AvgOfSeq(array));
        Console.WriteLine(Sum(array));
        Console.WriteLine(Prod(array));
    }

    public static int FindMax(string[] array)
    {
        int max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (int.Parse(array[i]) > max)
            {
                max = int.Parse(array[i]);
            }
        }
        return max;
    }

    public static int FindMin(string[] array)
    {
        int min = int.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (int.Parse(array[i]) < min)
            {
                min = int.Parse(array[i]);
            }
        }
        return min;
    }

    static double AvgOfSeq(string[] array)
    {
        double avg = 0;
        for (int i = 0; i < array.Length; i++)
        {
            avg += int.Parse(array[i]);
        }
        return avg /= array.Length;
    }

    public static int Sum(string[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += int.Parse(array[i]);
        }
        return sum;
    }

    public static int Prod(string[] array)
    {
        int sum = 1;
        for (int i = 0; i < array.Length; i++)
        {
            sum *= int.Parse(array[i]);
        }
        return sum;
    }
}