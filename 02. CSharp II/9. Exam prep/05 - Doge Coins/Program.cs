using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var field = Input();

        for (int i = 0; i < field.GetLength(0); i++)
        {
            for (int j = 0; j < field.GetLength(1); j++)
            {
                if (i == 0 && j == 0)// if we are on dog position continue to next iteration
                {
                    continue;
                }

                if (i == 0)// if we are on 0 line
                {
                    field[0, j] += field[0, j - 1];
                    continue;
                }
                if (j == 0)// if we are on 0 column
                {
                    field[i, 0] += field[i - 1, 0];
                    continue;
                }
                field[i, j] += field[i - 1, j] > field[i, j - 1] ? field[i - 1, j] : field[i, j - 1];
            }
        }

        //Console.WindowWidth = 100;
        //Console.BufferWidth = 100;
        //for (int i = 0; i < field.GetLength(0); i++)
        //{
        //    for (int j = 0; j < field.GetLength(1); j++)
        //    {
        //        Console.Write("{0,4}", field[i, j]);
        //    }
        //    Console.WriteLine();
        //}
        Console.WriteLine(field[field.GetLength(0) - 1, field.GetLength(1) - 1]);
    }

    static long[,] Input()
    {
        string line = Console.ReadLine();
        var numbersAsStrings = line.Split(' ');
        int n = int.Parse(numbersAsStrings[0]);
        int m = int.Parse(numbersAsStrings[1]);


        int k = int.Parse(Console.ReadLine());

        long[,] field = new long[n, m];

        for (int i = 0; i < k; i++)
        {
            line = Console.ReadLine();
            numbersAsStrings = line.Split(' ');
            int x = int.Parse(numbersAsStrings[0]);
            int y = int.Parse(numbersAsStrings[1]);

            field[x, y] += 1;
        }
        return field;
    }
}