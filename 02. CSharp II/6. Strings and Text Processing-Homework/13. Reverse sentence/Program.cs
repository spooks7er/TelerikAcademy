using System;
using System.Collections.Generic;
using System.Text;
//Problem 13. Reverse sentence
//• Write a program that reverses the words in given sentence.
class Program
{
    static void Main(string[] args)
    {
        //string sentance = Console.ReadLine();

        string sentance = "C# is not C++, not PHP and not Delphi!";

        string endSentance = sentance.Substring(sentance.Length - 1, 1);

        string[] sentanceArr = sentance.Split(',');

        string[][] sentanceChars = new string[sentanceArr.Length][];

        for (int i = 0; i < sentanceChars.Length; i++)
        {
            sentanceChars[i] = sentanceArr[i].Split(new char[] {' ', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(sentanceChars[i]);
        }

        StringBuilder output = new StringBuilder();
        for (int i = sentanceChars.Length - 1; i >= 0; i--)
        {
            output.Append(string.Join(" ", sentanceChars[i]));
            if (i != 0)
            {
                output.Append(", ");
            }
        }
        output.Append(endSentance);

        //Console.WriteLine(sentance);
        Console.WriteLine(output.ToString());
    }
}