using System;
using System.IO;
using System.Text;
//Problem 3. Line numbers
//• Write a program that reads a text file and inserts line numbers in front of each of its lines.
//• The result should be written to another text file.
class Program
{
    static void Main(string[] args)
    {
        string firstFile = @"..\..\SomeText1.txt";
        string secondFile = @"..\..\SomeText2.txt";
        StringBuilder result = new StringBuilder();
        using (StreamReader stream = new StreamReader(firstFile))
        {
            string line;
            int lineNumber = 1;
            while ((line = stream.ReadLine()) != null)
            {
                result.AppendLine(String.Format("{0,-5:D3}{1}", lineNumber, line));
                lineNumber++;
            }

            if (result.Length == 0)
            {
                result.AppendLine("There is no text in the file!");
            }

            File.WriteAllLines(secondFile, result.ToString().Split('\n'));
            
            Console.WriteLine("Done!");
        }
    }
}