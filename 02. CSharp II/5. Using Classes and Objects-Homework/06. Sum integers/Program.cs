using System;
using System.Linq;
//You are given a sequence of positive integer values written into a string, separated by spaces.
//• Write a function that reads these values from given string and calculates their sum.
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sequence of positive integer values, separated by spaces.");
        string numbers = Console.ReadLine();

        //string numbers = "43 68 9 23 318";

        Console.WriteLine(SumSeq(numbers));
    }

    private static int SumSeq(string numbers)
    {
        int[] array = numbers.Split(' ').Select(int.Parse).ToArray();
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }
}