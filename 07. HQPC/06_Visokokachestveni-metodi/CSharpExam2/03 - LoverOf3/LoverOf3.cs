using System;
using System.Linq;

public class LoverOf3
{
    private static int[,] matrix;
    private static int row;
    private static int col;

    public static void Main(string[] args)
    {
        string firstLine = Console.ReadLine();
        var dimensions = firstLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int dirNum = int.Parse(Console.ReadLine());
        string[] dirs = new string[dirNum];
        int[] steps = new int[dirNum];

        for (int i = 0; i < dirNum; i++)
        {
            string myString = Console.ReadLine();
            string dir = myString.Substring(0, 2);
            int times = int.Parse(myString.Substring(3));
            dirs[i] = dir;
            steps[i] = times;
        }

        matrix = new int[dimensions[0], dimensions[1]];
        int mult = 0;

        for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
        {
            int start = mult * 3;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = start;
                start += 3;
            }

            mult++;
        }

        row = matrix.GetLength(0) - 1;
        col = 0;
        int sum = 0;

        for (int i = 0; i < dirs.Length; i++)
        {
            switch (dirs[i])
            {
                case "RU":
                case "UR": sum += CollectPoints(steps[i], -1, 1);
                    break;
                case "LU":
                case "UL": sum += CollectPoints(steps[i], -1, -1);
                    break;
                case "LD":
                case "DL": sum += CollectPoints(steps[i], 1, -1);
                    break;
                case "RD":
                case "DR": sum += CollectPoints(steps[i], 1, 1);
                    break;
            }
        }

        Console.WriteLine(sum);
    }

    public static int CollectPoints(int stepsCount, int rowDir, int colDir)
    {
        int sum = 0;

        for (int j = 0; j < stepsCount; j++)
        {
            if (!InMatrix(matrix, row, col))
            {
                break;
            }

            sum += matrix[row, col];
            matrix[row, col] = 0;

            row += rowDir;
            col += colDir;
        }

        row -= rowDir;
        col -= colDir;

        return sum;
    }

    public static bool InMatrix(int[,] matrix, int row, int col)
    {
        if (row < 0 || col < 0 || row == matrix.GetLength(0) || col == matrix.GetLength(1))
        {
            return false;
        }

        return true;
    }
}