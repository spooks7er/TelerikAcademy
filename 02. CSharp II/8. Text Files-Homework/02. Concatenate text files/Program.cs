using System;
using System.IO;
//Problem 2. Concatenate text files
//• Write a program that concatenates two text files into another text file.
class Program
{
    static void Main(string[] args)
    {
        string firstFile = @"..\..\SomeText1.txt";
        string secondFile = @"..\..\SomeText2.txt";
        string concatFile = @"..\..\SomeTextConcat.txt";
        
        string firstString = File.ReadAllText(firstFile);
        string secondString = File.ReadAllText(secondFile);

        File.WriteAllText(concatFile, firstString + secondString);

        Console.WriteLine("Done!");
    }
}