using System;

class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        //int x = 5;
        int y = x;
        int z = x / 2 + 1;
        int h = (3 * x) - 2;
        int w = (z + x) * 2 - 3;

        int row = h;
        int col = w;
        char[,] logo = new char[row, col];
        //blank
        for (int i = 0; i < logo.GetLength(0); i++)
        {
            for (int j = 0; j < logo.GetLength(1); j++)
            {
                logo[i, j] = '.';
            }
        }
        //draw left horn
        int curCol = 0;
        int curRow = z-1;
        for (int i = 0; i < z; i++)
        {
            logo[curRow, curCol] = '*';
            curRow--;
            curCol++;
        }
        //draw left to right big line
        curRow++;
        curCol--;
        for (int i = 0; i < (2*x)-1; i++)
        {
            logo[curRow, curCol] = '*';
            curRow++;
            curCol++;
        }
        //draw right to left small line
        curRow--;
        curCol--;
        for (int i = 0; i < x; i++)
        {
            logo[curRow, curCol] = '*';
            curRow++;
            curCol--;
        }
        //draw right to left second small line up
        curRow--;
        curCol++;
        for (int i = 0; i < x; i++)
        {
            logo[curRow, curCol] = '*';
            curRow--;
            curCol--;
        }
        //draw left to right second big line up
        curRow++;
        curCol++;
        for (int i = 0; i < (2 * x) - 1; i++)
        {
            logo[curRow, curCol] = '*';
            curRow--;
            curCol++;
        }
        //draw right horn
        curRow++;
        curCol--;
        for (int i = 0; i < z; i++)
        {
            logo[curRow, curCol] = '*';
            curRow++;
            curCol++;
        }
        //print
        for (int i = 0; i < logo.GetLength(0); i++)
        {
            for (int j = 0; j < logo.GetLength(1); j++)
            {
                Console.Write(logo[i, j]);
            }
            Console.WriteLine();
        }
    }
}