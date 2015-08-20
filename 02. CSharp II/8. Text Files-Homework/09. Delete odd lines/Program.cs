using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 9. Delete odd lines
//• Write a program that deletes from given text file all odd lines.
//• The result should be in the same file.
class Program
{
    static void Main(string[] args)
    {
        string firstFile = @"..\..\SomeText1.txt";
        string secondFile = @"..\..\SomeText2.txt";

        StringBuilder result = new StringBuilder();

        using (StreamReader reader = File.OpenText(firstFile))
        {
            string currentLine;
            int line = 0;

            while (!reader.EndOfStream)
            {
                currentLine = reader.ReadLine();
                line++;
                if (line % 2 == 0)
                {
                    result.AppendLine(currentLine);
                }
            }

        }
        using (StreamWriter writer = File.AppendText(secondFile))
        {
            writer.WriteLine(result);
        }
        Console.WriteLine("Done!");
    }
}