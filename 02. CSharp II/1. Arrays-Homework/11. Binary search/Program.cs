using System;
//Write a program that finds the index of given element in a sorted array of integers
//by using the Binary search algorithm.
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number for length of array:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number we are searching for:");
        int s = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Enter {0} numbers, each on a new line.", n);
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);
        int index = BinarySearch(array, s, 0, array.Length);

        Console.WriteLine("The Array's elements afer the sorting:\n {0} ", string.Join(", ", array));
        Console.WriteLine("The index of number {0} is {1}.", s, index);
    }

    static int BinarySearch(int[] array, int value, int left, int right)
    {
        while (left <= right)
        {
            int middle = (left + right) / 2;
            if (array[middle] == value)
            {
                return middle;
            }
            else if (array[middle] > value)
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }
        return -1;
    }
}