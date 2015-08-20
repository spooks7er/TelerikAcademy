using System;
//Write a method that returns the index of the first element in array that is 
//larger than its neighbours, or  -1 , if there’s no such element.
//Use the method from the previous exercise.
class Program
{
    static void Main(string[] args)
    {
                   //0  1  2  3  4  5  6  7  8  9 10
        int[] n1 = { 6, 2, 8, 3, 6, 7, 2, 4, 7, 9, 0 };
        //int[] n1 = { 1, 2, 3, 4, 5};

        Console.WriteLine(Check(n1));
    }

    public static int Check(int[] arr)
    {
        int i;
        for (i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
            {
                return i;
            }
        }
        return i = -1;
    }
}