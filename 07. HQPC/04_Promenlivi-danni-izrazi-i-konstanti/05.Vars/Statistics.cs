using System;

class Statistics
{
    public void PrintStatistics(double[] arr, int count)
    {
        double max = 0;

        for (int i = 0; i < count; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        PrintMax(max);

        for (int i = 0; i < count; i++)
        {
            if (arr[i] < max)
            {
                max = arr[i];
            }
        }

        PrintMin(max);

        double sum = 0;

        for (int i = 0; i < count; i++)
        {
            sum += arr[i];
        }

        PrintAvg(sum / count);
    }

    static void PrintMax(double number)
    {
        Console.WriteLine(number);
    }

    static void PrintMin(double number)
    {
        Console.WriteLine(number);
    }

    static void PrintAvg(double number)
    {
        Console.WriteLine(number);
    }
}