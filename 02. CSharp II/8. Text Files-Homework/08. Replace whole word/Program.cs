using System;
using System.IO;
using System.Text;
//Problem 8. Replace whole word
//• Modify the solution of the previous problem to replace only whole words (not strings).
class Program
{
    static void Main(string[] args)
    {
        string firstFile = @"..\..\SomeText1.txt";
        string secondFile = @"..\..\SomeText2.txt";
        
        const string from = "start";
        const string to = "finish";

        using (StreamReader reader = new StreamReader(firstFile))
        {
            StringBuilder currentLine;
            using (StreamWriter writer = new StreamWriter(secondFile))
            {
                while (!reader.EndOfStream)
                {
                    currentLine = new StringBuilder(reader.ReadLine());
                    writer.WriteLine(Replace(currentLine, from, to));
                }
                Console.WriteLine("Done!");
            }
        }

    }

    private static string Replace(StringBuilder currentLine, string from, string to)
    {
        int startIndex = 0;
        string checkLine = currentLine.ToString();
        while (startIndex < currentLine.Length &&
            checkLine.IndexOf(from, StringComparison.OrdinalIgnoreCase) != -1)
        {
            startIndex = checkLine.IndexOf(from, StringComparison.OrdinalIgnoreCase);
            bool startOfWord = (startIndex == 0 ||
                !Char.IsLetterOrDigit(currentLine[startIndex - 1]));

            bool endOfWord = ((startIndex + from.Length) == currentLine.Length ||
                !Char.IsLetterOrDigit(currentLine[startIndex + from.Length]));

            if (startOfWord && endOfWord)
            {
                currentLine = currentLine
                    .Replace(currentLine.ToString()
                    .Substring(startIndex, from.Length),
                    to, startIndex, from.Length);
            }

            startIndex += to.Length;
            checkLine = currentLine.ToString().Substring(startIndex);
            checkLine = checkLine.PadLeft(currentLine.Length, '*');
        }

        return currentLine.ToString();
    }
}