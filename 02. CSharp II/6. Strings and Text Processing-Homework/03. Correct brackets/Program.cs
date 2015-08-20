using System;
//Problem 3. Correct brackets
//• Write a program to check if in a given expression the brackets are put correctly.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your expression:");
        string input = Console.ReadLine();

        //string input = ")((a + b) / 5 - d)(";

        Console.WriteLine(BracketChecker(input)? 
            "The brackets are put correctly!": 
            "The brackets are put incorrectly!");
    }

    public static bool BracketChecker(string input)
    {
        int bracketCounter = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                bracketCounter++;
            }
            else if (input[i] == ')')
            {
                bracketCounter++;
            }
            if (bracketCounter < 0)
            {
                return false;
            }
        }
        return bracketCounter == 0;
    }
}