using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        //int n = 4;
        //int d = 13;

        int h = 2 * n + 1;
        int w = h;

        int f = d * 2 + 4;

        int g = (n - (d / 2) - 1) * 2 - 1;


        int realW = f + g;

        //Console.WriteLine(new string('.', n - (d / 2) - 1) + "X" + new string('#', d) + "X" + new string('.', n - (d / 2) - 1));

        char[,] carpet = new char[h, realW];
        int row = h;
        int col = w;
        //blank
        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < realW; j++)
            {
                carpet[i, j] = '.';
            }
        }
        //right border
        int curCol = 0;
        int curRow = 0;
        for (int i = 0; i < h / 2; i++)
        {
            carpet[curRow, curCol] = '\\';
            curRow++;
            curCol++;
        }
        carpet[curRow, curCol] = 'X';
        curRow++;
        curCol--;
        for (int i = h / 2 + 1; i < h; i++)
        {
            carpet[curRow, curCol] = '/';
            curRow++;
            curCol--;
        }

        //left brder
        curRow = 0;
        curCol = realW - 1;
        for (int i = 0; i < h / 2; i++)
        {
            carpet[curRow, curCol] = '/';
            curRow++;
            curCol--;
        }
        carpet[curRow, curCol] = 'X';
        curRow++;
        curCol++;
        for (int i = h / 2 + 1; i < h; i++)
        {
            carpet[curRow, curCol] = '\\';
            curRow++;
            curCol++;
        }

        //inner border top
        int innerlen = (h - d - 2) / 2;
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
        curRow = h - 1;
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
            for (int j = 0; j < h; j++)
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
            for (int j = 0; j < h; j++)
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
        int start = (realW - w) / 2;

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