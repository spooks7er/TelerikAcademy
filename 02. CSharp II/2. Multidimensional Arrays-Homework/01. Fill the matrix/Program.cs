using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int numbers = 0;
        int valRow = 0;
        int valCol = 0;

        //a)
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                matrix[valRow, valCol] = ++numbers;
                valRow++;
            }
            valRow = 0;
            valCol++;
        } Console.WriteLine("a)");
        PrinMatrix(matrix);

        //b)
        numbers = 0;
        valRow = 0;
        valCol = 0;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            if (valCol % 2 != 0)
            {
                valRow = matrix.GetLength(0) - 1;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[valRow, valCol] = ++numbers;
                    valRow--;
                }
            }
            else
            {
                valRow = 0;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[valRow, valCol] = ++numbers;
                    valRow++;
                }
            }
            valCol++;
        } Console.WriteLine("b)");
        PrinMatrix(matrix);

        //c)        
        Array.Clear(matrix, 0, matrix.Length);
        numbers = 0;
        int row = matrix.GetLength(1) - 1;
        int col = 0;
        int rowAdd = 0;
        int colAdd = 0;
        int sqCount = 1;
        int half = 0;
        for (int i = 0; i < (n * 2) - 1; i++)
        {
            for (int j = 0; j < sqCount; j++)
            {
                matrix[row + j, col + j] = ++numbers;
            }
            if (sqCount < matrix.GetLength(0) && half == 0)
            {
                row--;
                sqCount++;
            }
            else
            {
                half = 1;
                col++;
                sqCount--;
            }
        } Console.WriteLine("c)");
        PrinMatrix(matrix);

        //d) spiral
        Array.Clear(matrix, 0, matrix.Length);
        string direction = "down";
        row = 0;
        col = 0;

        for (int i = 1; i <= n * n; i++)
        {
            if (direction == "right" && (col >= n || matrix[row, col] != 0))
            {
                row--;
                col--;
                direction = "up";
            }
            else if (direction == "down" && (row >= n || matrix[row, col] != 0))
            {
                row--;
                col++;
                direction = "right";
            }
            else if (direction == "left" && (col < 0 || matrix[row, col] != 0))
            {
                row++;
                col++;
                direction = "down";
            }
            else if (direction == "up" && (row < 0 || matrix[row, col] != 0))
            {
                col--;
                row++;
                direction = "left";
            }

            matrix[row, col] = i;

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
        } Console.WriteLine("d)");
        PrinMatrix(matrix);
    }

    static void PrinMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}