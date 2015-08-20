﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 4. Compare text files
//• Write a program that compares two text files line by line and
//prints the number of lines that are the same and the number of lines that are different.
//• Assume the files have equal number of lines.
class Program
{
    static void Main(string[] args)
    {
        string firstFile = @"..\..\SomeText1.txt";
        string secondFile = @"..\..\SomeText2.txt";
        int sameCount = 0;
        int differentCount = 0;
        StreamReader firstStream = new StreamReader(firstFile);
        StreamReader secondStream = new StreamReader(secondFile);
        using (firstStream)
        {
            using (secondStream)
            {
                string firstLine;
                string secondLine;

                firstLine = firstStream.ReadLine();
                secondLine = secondStream.ReadLine();
                while (firstLine != null && secondLine != null)
                {
                    if (firstLine == secondLine)
                    {
                        ++sameCount;
                    }
                    else
                    {
                        ++differentCount;
                    }
                    firstLine = firstStream.ReadLine();
                    secondLine = secondStream.ReadLine();
                }

                Console.WriteLine("SAME LINES COUNT:       {0}", sameCount);
                Console.WriteLine("DIFFERENT LINES COUNT:  {0}", differentCount);
            }
        }

    }
}