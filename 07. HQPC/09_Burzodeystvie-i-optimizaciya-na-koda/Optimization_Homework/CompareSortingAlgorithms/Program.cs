using System;
using System.Diagnostics;

namespace CompareSortingAlgorithms
{
    class Program
    {
        private const int Samples = 15;
        private const int ArrayLength = 1000;

        private const int SkipFirst = 0; // -1 or 0
        private static readonly Random rand = new Random();

        static void Main(string[] args)
        {
            int[] randomArray = new int[ArrayLength];

            for (int i = 0; i < ArrayLength; i++)
            {
                randomArray[i] = rand.Next();
            }
            
            Console.WriteLine("Sorting Algorithms Speed Compare\n");
            Console.WriteLine("{0} Samples\n", Samples);
            Console.WriteLine("{0} Array Length\n", ArrayLength);

            Console.WriteLine("Selection Sort:\n");
            Console.WriteLine("{0:F6} Milliseconds\n", CompareSelectionSort(randomArray));

            Console.WriteLine("Merge Sort:\n");
            Console.WriteLine("{0:F6} Milliseconds\n", CompareMergeSort(randomArray));

            Console.WriteLine("Quick Sort:\n");
            Console.WriteLine("{0:F6} Milliseconds\n", CompareQuickSort(randomArray));

        }

        public static double CompareSelectionSort(int[] array)
        {
            double timeElapsed = 0;
            int[] arrayCopy = new int[array.Length];

            for (int i = 0; i < Samples; i++)
            {
                Array.Copy(array, arrayCopy, ArrayLength);

                Stopwatch sw = Stopwatch.StartNew();
                SelectionSort(arrayCopy);

                if (i > SkipFirst)
                {
                    timeElapsed += sw.Elapsed.TotalMilliseconds;
                    Console.WriteLine(sw.Elapsed);
                }
            }
            return timeElapsed / Samples;
        }

        private static double CompareMergeSort(int[] array)
        {
            double timeElapsed = 0;
            int[] arrayCopy = new int[array.Length];

            for (int i = 0; i < Samples; i++)
            {
                Array.Copy(array, arrayCopy, ArrayLength);

                Stopwatch sw = Stopwatch.StartNew();

                Splits(arrayCopy);
                if (i > SkipFirst)
                {
                    timeElapsed += sw.Elapsed.TotalMilliseconds;
                    Console.WriteLine(sw.Elapsed);
                }
            }
            return timeElapsed / Samples;
        }

        private static double CompareQuickSort(int[] array)
        {
            double timeElapsed = 0;
            int[] arrayCopy = new int[array.Length];

            for (int i = 0; i < Samples; i++)
            {
                Array.Copy(array, arrayCopy, ArrayLength);

                Stopwatch sw = Stopwatch.StartNew();

                Quicksort(arrayCopy, 0, arrayCopy.Length - 1);
                if (i > SkipFirst)
                {
                    timeElapsed += sw.Elapsed.TotalMilliseconds;
                    Console.WriteLine(sw.Elapsed);
                }
            }
            return timeElapsed / Samples;
        }



        /// <summary>
        /// Selection Sort
        /// </summary>
        /// <param name="array"></param>
        private static void SelectionSort(int[] array)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int k = j + 1; k < array.Length; k++)
                {
                    if (array[j] > array[k])
                    {
                        int tmp = array[j];
                        array[j] = array[k];
                        array[k] = tmp;
                    }
                }
            }
        }


        /// <summary>
        /// Merge Sort - Split
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static int[] Splits(int[] arr)
        {
            if (arr.Length == 1)
            {
                return arr;
            }

            int middle = arr.Length / 2;
            int[] leftArr = new int[middle];
            int[] rightArr = new int[arr.Length - middle];

            for (int i = 0; i < middle; i++)
            {
                leftArr[i] = arr[i];
            }

            for (int i = middle, j = 0; i < arr.Length; i++, j++)
            {
                rightArr[j] = arr[i];
            }

            leftArr = Splits(leftArr);
            rightArr = Splits(rightArr);

            return Merge(leftArr, rightArr);
        }

        /// <summary>
        /// Merge Sort - Merge
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static int[] Merge(int[] left, int[] right)
        {
            int leftIncrease = 0;
            int rightIncrease = 0;
            int[] arr = new int[left.Length + right.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (rightIncrease == right.Length ||
                    ((leftIncrease < left.Length) && (left[leftIncrease] <= right[rightIncrease])))
                {
                    arr[i] = left[leftIncrease];
                    leftIncrease++;
                }
                else if (leftIncrease == left.Length ||
                    ((rightIncrease < right.Length) && (left[leftIncrease] >= right[rightIncrease])))
                {
                    arr[i] = right[rightIncrease];
                    rightIncrease++;
                }
            }
            return arr;
        }


        /// <summary>
        /// Quick Sort
        /// </summary>
        /// <param name="array"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        private static void Quicksort(int[] array, int left, int right)
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
                    int tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;

                    i++;
                    j--;
                }
            }

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
