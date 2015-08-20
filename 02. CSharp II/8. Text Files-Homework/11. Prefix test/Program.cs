using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 11. Prefix "test"
//• Write a program that deletes from a text file all words that start with the prefix "test".
//• Words contain only the symbols  0…9 ,  a…z ,  A…Z ,  _ .

class Program
{
    static void Main(string[] args)
    {
        string firstFile = @"..\..\SomeText1.txt";
        string secondFile = @"..\..\SomeText2.txt";
        StringBuilder result = new StringBuilder();

        using (StreamReader reader = new StreamReader(firstFile))
        {
            string currentLine;
            while (!reader.EndOfStream)
            {
                currentLine = reader.ReadLine();
                string[] separatedWords = currentLine
                    .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .Where(x => !x.StartsWith("test", StringComparison.OrdinalIgnoreCase))
                    .ToArray();

                result.AppendLine(string.Join(" ", separatedWords));
            }
        }

        using (StreamWriter writer = new StreamWriter(secondFile))
        {
            writer.Write(result.ToString());
        }
        Console.WriteLine("Done!");
    }
}