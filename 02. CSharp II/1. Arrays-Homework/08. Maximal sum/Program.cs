using System;
//• Write a program that finds the sequence of maximal sum in given array.
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

        int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        int bestStart = 0;
        int bestEnd = 0;
        int bestSum = int.MinValue;

        int startIndex = 0; 
        int currentSum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (currentSum <= 0)
            {
                startIndex = i;
                currentSum = 0;
            }

            currentSum += array[i];

            if (currentSum > bestSum)
            {
                bestSum = currentSum;
                bestStart = startIndex;
                bestEnd = i;
            }
        }

        Console.WriteLine("The Array's elements: {0} ", string.Join(", ", array));
        Console.WriteLine("Max sum is {0}", bestSum);
        Console.Write("Sequence of maximal sum is ");
        for (int i = bestStart; i <= bestEnd; i++)
        {
            if (i != bestEnd)
            {
                Console.Write(array[i] + ", ");

            }
            else
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}