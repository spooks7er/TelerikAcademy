using System;
using System.Linq;
//Write a program that reads two integer numbers  N  and  K  and an array of  N  elements from the console.
//• Find in the array those  K  elements that have maximal sum.
class Program
{
    static void Main()
    {
        //Console.WriteLine("Enter N");
        //int n = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter K");
        //int k = int.Parse(Console.ReadLine());
        //int[] numbers = new int[n];
        //int[] kNumbers = new int[k];
        //Console.WriteLine("Enter {0} numbers, each on a new line.", n);
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    numbers[i] = int.Parse(Console.ReadLine());
        //}
        int[] numbers = { 6, 9, 7, 1, 8, 10, 3, 2, 4, 5 };
        int[] kNumbers = new int[3];

        Array.Sort(numbers);

        for (int i = 0; i < kNumbers.Length; i++)
        {
            kNumbers[kNumbers.Length - i - 1] = numbers[numbers.Length - 1 - i];
        }

        Console.WriteLine("The sequence of K numbers is: {0}.", string.Join(", ", kNumbers));
        Console.WriteLine("Their sum is : {0}", kNumbers.Sum());
    }
}