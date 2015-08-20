using System;
class Program_Old
{
    static void Main_old()
    {
        int n = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        //int n = 4;
        //int d = 13;

        int height = 2 * n + 1;
        int width = height;

        int f = d * 2 + 4;

        int g = (n - (d / 2) - 1) * 2 - 1;


        int realW = f + g;

        char[,] carpet = new char[height, realW];
        int row = height;
        int col = width;

        //blank
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < realW; j++)
            {
                carpet[i, j] = '.';
            }
        }

        //right border
        int curCol = 0;
        int curRow = 0;
        for (int i = 0; i < height / 2; i++)
        {
            carpet[curRow, curCol] = '\\';
            curRow++;
            curCol++;
        }
        carpet[curRow, curCol] = 'X';
        curRow++;
        curCol--;
        for (int i = height / 2 + 1; i < height; i++)
        {
            carpet[curRow, curCol] = '/';
            curRow++;
            curCol--;
        }

        //left brder
        curRow = 0;
        curCol = realW - 1;
        for (int i = 0; i < height / 2; i++)
        {
            carpet[curRow, curCol] = '/';
            curRow++;
            curCol--;
        }

        carpet[curRow, curCol] = 'X';
        curRow++;
        curCol++;

        for (int i = height / 2 + 1; i < height; i++)
        {
            carpet[curRow, curCol] = '\\';
            curRow++;
            curCol++;
        }

        //inner border top
        int innerlen = (height - d - 2) / 2;
        curRow = 0;
        curCol = d + 1;
        for (int i = 0; i < innerlen; i++)
        {
            carpet[curRow, curCol] = '\\';
            curRow++;
            curCol++;
        }
        carpet[curRow, curCol] = 'X';
        curRow--;
        curCol++;
        for (int i = 0; i < innerlen; i++)
        {
            carpet[curRow, curCol] = '/';
            curRow--;
            curCol++;
        }

        //inner border bot
        curRow = height - 1;
        curCol = d + 1;
        for (int i = 0; i < innerlen; i++)
        {
            carpet[curRow, curCol] = '/';
            curRow--;
            curCol++;
        }

        carpet[curRow, curCol] = 'X';
        curRow++;
        curCol++;

        for (int i = 0; i < innerlen; i++)
        {
            carpet[curRow, curCol] = '\\';
            curRow++;
            curCol++;
        }

        // FILL MAMKA MU
        int fillRowLeft = 0;
        int fillColLeft = 1;
        for (int i = 0; i < d; i++)
        {
            fillRowLeft = 0;
            fillColLeft = 1 + i;
            for (int j = 0; j < height; j++)
            {
                carpet[fillRowLeft, fillColLeft] = '#';
                fillRowLeft++;
                fillColLeft++;
            }
        }

        int fillRowRight = 0;
        int fillColRight = realW - 2;
        for (int i = 0; i < d; i++)
        {
            fillRowRight = 0;
            fillColRight = (realW - 2) - i;
            for (int j = 0; j < height; j++)
            {
                carpet[fillRowRight, fillColRight] = '#';
                fillRowRight++;
                fillColRight--;
            }
        }

        //print the whole canvas
        //for (int i = 0; i < carpet.GetLength(0); i++)
        //{
        //    for (int j = 0; j < carpet.GetLength(1); j++)
        //    {
        //        Console.Write(carpet[i, j]);
        //    }
        //    Console.WriteLine();
        //}

        //print only carpet
        int start = (realW - width) / 2;

        for (int i = 0; i < carpet.GetLength(0); i++)
        {
            for (int j = start; j < carpet.GetLength(1) - start; j++)
            {
                Console.Write(carpet[i, j]);
            }
            Console.WriteLine();
        }
    }
}