using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
//Problem 6. Save sorted names
//• Write a program that reads a text file containing a list of strings, 
//sorts them and saves them to another text file.
class Program
{
    static void Main(string[] args)
    {
        string firstFile = @"..\..\SomeText1.txt";
        string secondFile = @"..\..\SomeText2.txt";
        List<string> names = new List<string>();

        using (StreamReader stream = new StreamReader(firstFile))
        {
            names = stream.ReadToEnd()
                .Split('\n')
                .Select(x => x.Trim())
                .OrderBy(x => x)
                .ToList();

            File.WriteAllLines(secondFile, names);

            Console.WriteLine("Done!");
        }
    }
}