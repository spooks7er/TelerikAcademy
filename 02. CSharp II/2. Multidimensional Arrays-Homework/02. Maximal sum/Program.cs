using System;
//Write a program that reads a rectangular matrix of size  N x M  
//and finds in it the square  3 x 3  that has maximal sum of its elements.
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        //int[,] matrix = {{1,2,3,4,5,6,7},
        //                 {4,6,1,3,7,9,3},
        //                 {3,2,3,4,5,6,7},
        //                 {9,6,1,3,7,9,3},
        //                 {6,2,3,4,8,6,7},
        //                 {4,6,1,3,7,9,3}};

        int currSum = 0;
        int bestSum = 0;
        int currIndexI = 0;
        int currIndexJ = 0;

        for (int i = 0; i < matrix.GetLength(0) - 2; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 2; j++)
            {
                currSum =
                    matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                    matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                    matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                if (currSum > bestSum)
                {
                    bestSum = currSum;
                    currIndexI = i;
                    currIndexJ = j;
                }
            }
        }
        PrinMatrix(matrix);
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("{0,3}{1,3}{2,3}", matrix[currIndexI + i, currIndexJ], matrix[currIndexI + i, currIndexJ + 1], matrix[currIndexI + i, currIndexJ + 2]);
        }
        Console.WriteLine(bestSum);
    }

    static void PrinMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,3}", matrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}