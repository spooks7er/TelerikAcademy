using System;
using System.Collections.Generic;
//Using loops write a program that converts an integer number to its binary representation.
//• The input is entered as long. The output should be a variable of type string.
//• Do not use the built-in .NET functionality.
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int number = int.Parse(input);
        List<int> nums = new List<int>();
        while (number >= 1)
        {
            nums.Add(number % 2);
            number /= 2;
        }

        for (int i = 0; i < nums.Count; i++)
        {
            Console.Write(nums[nums.Count - (i + 1)]);
        }
        Console.WriteLine();
    }
}