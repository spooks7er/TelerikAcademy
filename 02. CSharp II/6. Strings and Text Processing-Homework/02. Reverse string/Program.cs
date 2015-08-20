using System;
using System.Text;
//Problem 2. Reverse string
//• Write a program that reads a string, reverses it and prints the result at the console.
class Program
{
    static void Main(string[] args)
    {
        Console.Write("input : ");
        string input = Console.ReadLine();

        StringBuilder output = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            output.Insert(0, input[i]);
        }
        Console.WriteLine("output: {0}",output.ToString());
    }
}