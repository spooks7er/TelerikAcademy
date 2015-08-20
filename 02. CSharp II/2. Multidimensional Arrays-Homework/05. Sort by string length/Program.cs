using System;
using System.Linq;
//You are given an array of strings. Write a method that sorts the array by the 
//length of its elements (the number of characters composing them).
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter array Length");
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter Array element {0} : ", i);
            array[i] = Console.ReadLine();
        }

        //string[]  array = { "aa", "aaaa", "aaaaaa", "aaaaa", "a", "aaa" };
        
        // LINQ is awesome
        Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));
        
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}