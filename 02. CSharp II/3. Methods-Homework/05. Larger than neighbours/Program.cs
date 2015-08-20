using System;
//Write a method that checks if the element at given position in given array of integers 
//is larger than its two neighbours (when such exist).
class Program
{
    static void Main(string[] args)
    {              //0  1  2  3  4  5  6  7  8  9 10
        int[] n1 = { 6, 2, 8, 3, 6, 7, 2, 4, 7, 9, 0 };
        int numberPos = 5;
        Console.WriteLine(Check(n1, numberPos));
    }
    public static bool Check(int[] arr, int pos)
    {
        if (arr[pos] > arr[pos - 1] && arr[pos] > arr[pos + 1])
        {
            return true;
        }
        return false;
    }
}