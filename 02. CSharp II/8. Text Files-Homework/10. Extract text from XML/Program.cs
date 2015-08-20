using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string firstFile = @"..\..\XML.xml";
        string secondFile = @"..\..\XMLnoTags.xml";

        StringBuilder result = new StringBuilder();

        using (StreamReader reader = File.OpenText(firstFile))
        {
            string currentLine;
            int line = 0;

            while (!reader.EndOfStream)
            {
                currentLine = reader.ReadLine();
                line++;
                result.AppendLine(Regex.Replace(currentLine, @"<[^>]+>|&nbsp;", "").Trim());
            }
        }
        using (StreamWriter writer = File.AppendText(secondFile))
        {
            writer.WriteLine(result.ToString().Trim());
        }
        Console.WriteLine("Done!");

    }
}