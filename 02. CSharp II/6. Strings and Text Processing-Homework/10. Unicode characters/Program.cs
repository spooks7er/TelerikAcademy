using System;
using System.Linq;
using System.Text;
//Problem 10. Unicode characters
//• Write a program that converts a string to a sequence of C# Unicode character literals.
//• Use format strings.
class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        StringBuilder output = new StringBuilder();
        foreach (byte b in input)
        {
            output.AppendFormat("\\u{0:x4}", b);
        }
        Console.WriteLine(output.ToString());
    }
}