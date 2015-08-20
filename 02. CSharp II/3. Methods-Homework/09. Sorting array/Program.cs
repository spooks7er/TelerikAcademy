using System;
//Write a method that return the maximal element in a portion of array of integers starting at given index.
//• Using it write another method that sorts an array in ascending / descending order.

class Program
{
    static void Main()
    {                 //0  1  2  3  4  5   6  7  8  9
        int[] array = { 6, 9, 7, 10, 8, 1, 3, 2, 4, 5 };
        Console.WriteLine("The array before sorting");
        Console.WriteLine(string.Join(", ", array));

        Console.WriteLine("Enter index for start");
        int startIndex = int.Parse(Console.ReadLine());

        Console.WriteLine("The max element in the portion starting at {0}",startIndex);
        Console.WriteLine(FindAtIndex(array, startIndex));

        Console.WriteLine("The array after sorting");
        SelectionSort(array, "desc");
        Console.WriteLine(string.Join(", ", array));
        
        Console.WriteLine("The max element in the portion starting at {0}", startIndex);
        Console.WriteLine(FindAtIndex(array, startIndex));
    }
    
    

    /// <summary>
    /// <param name="order">string "order" represents the order "asc" or "desc"</param>
    /// </summary>
    public static int[] SelectionSort(int[] array, string order)
    {
        if (order == "asc")
        {
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
        }
        else if (order == "desc")
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
        }
        return array;
    }

    public static int FindAtIndex(int[] array, int startIndex)
    {
        int max = 0;
        for (int i = startIndex; i < array.Length; i++)
        {
            if (array[i]>max)
            {
                max = array[i];
            }
        }
        return max;
    }
}