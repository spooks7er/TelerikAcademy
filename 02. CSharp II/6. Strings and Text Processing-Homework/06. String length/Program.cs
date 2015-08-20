using System;
using System.Text;
//Problem 6. String length
//• Write a program that reads from the console a string of maximum  20  characters. 
//If the length of the string is less than  20 , the rest of the characters should be filled with  * .
//• Print the result string into the console.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string of 20 or less characters.\n");
        string input = Console.ReadLine();
        Console.WriteLine();

        int numberOfStars = 20 - input.Length;
        if (numberOfStars < 0)
        {
            numberOfStars = 0;
        }
        StringBuilder output = new StringBuilder(0);

        output.Append(input);
        output.Append(new string('*', numberOfStars));
        Console.WriteLine("You string padded with * to 20 characters.\n");
        Console.WriteLine(output.ToString() + "\n");
    }
}