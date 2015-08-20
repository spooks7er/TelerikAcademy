﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Problem 5. Maximal area sum
//• Write a program that reads a text file containing a square matrix of numbers.
//• Find an area of size  2 x 2  in the matrix, with a maximal sum of its elements. 
//◦ The first line in the input file contains the size of matrix  N .
//◦ Each of the next  N  lines contain  N  numbers separated by space.
//◦ The output should be a single number in a separate text file.

//Example:

//input      output

//4 
//2 3 3 4 
//0 2 3 4 
//3 7 1 2 
//4 3 3 2    17 

class Program
{
    static void Main(string[] args)
    {
        string firstFile = @"..\..\SomeText1.txt";
        string secondFile = @"..\..\SomeText2.txt";

        using (StreamReader stream = new StreamReader(firstFile))
        {
            int size = int.Parse(stream.ReadLine());
            int[,] matrix = new int[size, size];

            GetMatrixNumbers(stream, matrix);
            File.WriteAllText(secondFile, GetMaxArea(matrix).ToString());
            Console.WriteLine("Done!");
        }
    }

    private static object GetMaxArea(int[,] matrix)
    {
        int maxValue = 0;
        int tempValue;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                tempValue = 0;

                for (int checkRow = 0; checkRow < 2; checkRow++)
                {
                    for (int checkCol = 0; checkCol < 2; checkCol++)
                    {
                        tempValue += matrix[row + checkRow, col + checkCol];
                    }
                }
                maxValue = Math.Max(maxValue, tempValue);
            }
        }
        return maxValue;
    }

    private static void GetMatrixNumbers(StreamReader stream, int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int[] currentLineNumbers = stream.ReadLine()
                .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = currentLineNumbers[col];
            }
        }
    }
}