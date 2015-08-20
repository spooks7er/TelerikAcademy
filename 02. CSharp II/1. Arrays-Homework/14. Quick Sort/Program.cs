using System;
//Write a program that sorts an array of strings using the Quick sort algorithm.
namespace Quicksort
{
    class Program
    {
        static void Main(string[] args)
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

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            // Sort the array
            Quicksort(array, 0, array.Length - 1);

            // Print the sorted array
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public static void Quicksort(int[] array, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = array[(left + right) / 2];

            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    int tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;

                    i++;
                    j--;
                }
            }
            // Recursive calls
            if (left < j)
            {
                Quicksort(array, left, j);
            }

            if (i < right)
            {
                Quicksort(array, i, right);
            }
        }
    }
}
