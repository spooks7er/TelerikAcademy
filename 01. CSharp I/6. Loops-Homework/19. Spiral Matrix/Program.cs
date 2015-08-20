using System;
//Write a program that reads from the console a positive integer number  n  (1 ≤ n ≤ 20) 
//and prints a matrix holding the numbers from  1  to  n*n  in the form of square spiral 
//like in the examples below.
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[,] spiral = new int[n, n];
        string direction = "right";
        int row = 0;
        int col = 0;
        for (int i = 1; i <= n * n; i++)
        {
            if (direction == "right" && (col >= n || spiral[row, col] != 0))
            {
                row++;
                col--;
                direction = "down";
            }
            else if (direction == "down" && (row >= n || spiral[row, col] != 0))
            {
                row--;
                col--;
                direction = "left";
            }
            else if (direction == "left" && (col < 0 || spiral[row, col] != 0))
            {
                row--;
                col++;
                direction = "up";
            }
            else if (direction == "up" && (row < 0 || spiral[row, col] != 0))
            {
                col++;
                row++;
                direction = "right";
            }

            spiral[row, col] = i;

            if (direction == "right")
            {
                col++;
            }
            else if (direction == "down")
            {
                row++;
            }
            else if (direction == "left")
            {
                col--;
            }
            else if (direction == "up")
            {
                row--;
            }
        }
        for (int i = 0; i < spiral.GetLength(0); i++)
        {
            for (int j = 0; j < spiral.GetLength(1); j++)
            {
                Console.Write("{0,4}", spiral[i, j]);
            }
            Console.WriteLine();
        }
    }
}