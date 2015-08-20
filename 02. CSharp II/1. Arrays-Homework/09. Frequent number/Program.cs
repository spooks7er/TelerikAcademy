using System;
//Write a program that finds the most frequent number in an array.
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

        int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

        Array.Sort(array);
        int count = 1;
        int currNum = array[0];
        int bestNum = 0;
        int bestCount = 1;

        for (int i = 1; i < array.Length; i++)
        {
            if (currNum == array[i])
            {
                count++;
                if (count > bestCount)
                {
                    bestNum = currNum;
                    bestCount = count;
                }
            }
            else
            {
                count = 1;
            }
            currNum = array[i];
        }
        Console.WriteLine("The number {0} is the most frequent, it's repeated {1} times.", bestNum, bestCount);
    }
}