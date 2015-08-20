using System;
//Write a program, that reads from the console an array of  N  integers and an integer  K, 
//sorts the array and using the method  Array.BinSearch()  
//finds the largest number in the array which is ≤ K. 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter array Length");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter array K");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter Array element {0} : ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        //int k = 8;
        //int[] array = {6,1,4,3,2};


        Array.Sort(array);
        int max = 0;
        int curr = 0;
        for (int i = 0; i <= k; i++)
        {
            curr = Array.BinarySearch(array, i);
            if (max<curr)
            {
                max = curr;
            }
        }
        Console.Write("The largest number in the array which is <= K is: ");
        Console.WriteLine(array[max]);
    }
}