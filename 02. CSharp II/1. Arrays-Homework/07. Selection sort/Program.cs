using System;

class Program
{
    static void Main()
    {
        //Console.WriteLine("Enter a number for length of array:");
        //int n = int.Parse(Console.ReadLine());

        //int[] array = new int[n];
        //Console.WriteLine("Enter {0} numbers, each on a new line.", n);
        //for (int i = 0; i < n; i++)
        //{
        //    array[i] = int.Parse(Console.ReadLine());
        //}

        int[] array = { 6, 9, 7, 1, 8, 10, 3, 2, 4, 5 };

        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    int tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;
                }
            }
        }
        Console.WriteLine(string.Join(", ", array));
    }
}