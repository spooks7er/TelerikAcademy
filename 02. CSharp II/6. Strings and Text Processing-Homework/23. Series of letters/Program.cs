using System;
using System.Text;
//Problem 23. Series of letters
//• Write a program that reads a string from the console and replaces
//all series of consecutive identical letters with a single one.

//Example:
//        input           output

//aaaaabbbbbcdddeeeedssaa abcdedsa 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter some sequence of random letters:");
        string text = Console.ReadLine();

        //string text = "aaaaabbbbbcdddeeeedssaa";

        StringBuilder result = new StringBuilder();

        char currentLetter = '*';

        foreach (char letter in text)
        {
            if (letter!=currentLetter)
            {
                currentLetter = letter;
                result.Append(letter);
            }
        }
        Console.WriteLine(result.ToString());
    }
}