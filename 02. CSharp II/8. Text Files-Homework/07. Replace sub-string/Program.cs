using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Problem 7. Replace sub-string
//• Write a program that replaces all occurrences of the sub-string  
//"start"  with the sub-string  "finish"  in a text file.
//• Ensure it will work with large files (e.g.  100 MB ).

class Program
{
    static void Main(string[] args)
    {
        string firstFile = @"..\..\SomeText1.txt";
        string secondFile = @"..\..\SomeText2.txt";

        using (StreamReader reader = new StreamReader(firstFile))
        {
            string currentLine;
            using (StreamWriter writer = new StreamWriter(secondFile))
            {
                while (!reader.EndOfStream)
                {
                    currentLine = reader.ReadLine();
                    currentLine = Regex
                        .Replace(currentLine, "start", "finish", RegexOptions.IgnoreCase);

                    writer.WriteLine(currentLine);
                }
                Console.WriteLine("Done!");
            }
        }
    }
}