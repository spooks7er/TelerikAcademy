using System;
//• Write a program that finds in given array of integers a sequence of given sum  S  (if present).
class Program
{
    static void Main()
    {
        //Console.WriteLine("Enter a number for length of array:");
        //int n = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter the sum we a searching for:");
        //int s = int.Parse(Console.ReadLine());
        //int[] array = new int[n];
        //Console.WriteLine("Enter {0} numbers, each on a new line.", n);
        //for (int i = 0; i < n; i++)
        //{
        //    array[i] = int.Parse(Console.ReadLine());
        //}

        int[] array = { 4, 3, 1, 4, 2, 5, 8 };
        int s = 8;

        int bestStart = 0;
        int bestEnd = 0;
        int bestSum = s;

        int startIndex = 0;
        int currentSum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            currentSum += array[i];
            if (currentSum>bestSum)
            {
                currentSum = array[i];
                startIndex = i;
            }
            else if (currentSum==bestSum)
            {
                bestSum = currentSum;
                bestStart = startIndex;
                bestEnd = i;
            }
        }

        Console.WriteLine("The Array's elements: {0} ", string.Join(", ", array));
        Console.Write("Sequence of containing the sum of {0} is ", s);
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