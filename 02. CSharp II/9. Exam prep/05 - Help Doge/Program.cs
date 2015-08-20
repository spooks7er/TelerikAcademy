using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

//doge         0         0         0         0
//   0     enemy         0         0         0
//   0         0     enemy     enemy         0
//   0         0         0         0      bone
class Program
{
    static int fx;
    static int fy;
    static void Main(string[] args)
    {
        var field = Input();

        for (int i = 0; i < field.GetLength(0); i++)
        {
            for (int j = 0; j < field.GetLength(1); j++)
            {
                //if (i == fx + 1 || j == fy + 1)
                //{
                //    break;
                //}

                if (i == 0 && j == 0)// if we are on dog position continue to next iteration
                {
                    field[0, 0] = 1;
                    continue;
                }

                if (field[i, j] == -1)// if we are on enemy make it equal to 0
                {
                    field[i, j] = 0;
                    continue;
                }

                if (i==0)// if we are on 0 line
                {
                    field[0, j] += field[0, j - 1];
                    continue;
                }
                if (j == 0)// if we are on 0 column
                {
                    field[i, 0] += field[i - 1, 0];
                    continue;
                }


                field[i, j] = field[i - 1, j] + field[i, j - 1];

            }
        }

        //Console.WindowWidth = 100;
        //Console.BufferWidth = 100;
        //for (int i = 0; i < field.GetLength(0); i++)
        //{
        //    for (int j = 0; j < field.GetLength(1); j++)
        //    {
        //        Console.Write("{0,8}", field[i, j]);
        //    }
        //    Console.WriteLine();
        //}

        Console.WriteLine(field[fx, fy]);
    }

    static BigInteger[,] Input()
    {
        string line = Console.ReadLine();
        var numbersAsStrings = line.Split(' ');
        int n = int.Parse(numbersAsStrings[0]);
        int m = int.Parse(numbersAsStrings[1]);

        line = Console.ReadLine();
        numbersAsStrings = line.Split(' ');
        fx = int.Parse(numbersAsStrings[0]);
        fy = int.Parse(numbersAsStrings[1]);

        int k = int.Parse(Console.ReadLine());

        BigInteger[,] field = new BigInteger[n, m];

        for (int i = 0; i < k; i++)
        {
            line = Console.ReadLine();
            numbersAsStrings = line.Split(' ');
            int x = int.Parse(numbersAsStrings[0]);
            int y = int.Parse(numbersAsStrings[1]);

            field[x, y] = -1;
        }
        return field;
    }


    static BigInteger[,] GetInput()
    {
        int[] matrixNM = Console.ReadLine()
             .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse).ToArray();

        BigInteger[,] field = new BigInteger[matrixNM[0], matrixNM[1]];

        int[] boneCoords = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse).ToArray();

        fx = boneCoords[0];
        fy = boneCoords[1];

        int dogeEnemies = int.Parse(Console.ReadLine());

        int[,] dogeEnemiesCoords = new int[dogeEnemies, 2];

        for (int i = 0; i < dogeEnemies; i++)
        {
            int[] dogeEnemiesCoordsInput = Console.ReadLine()
                  .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse).ToArray();

            for (int j = 0; j < dogeEnemiesCoordsInput.Length; j++)
            {
                dogeEnemiesCoords[i, j] = dogeEnemiesCoordsInput[j];
            }
        }

        for (int i = 0; i < field.GetLength(0); i++)
        {
            for (int j = 0; j < field.GetLength(1); j++)
            {
                field[i, j] = 0;
            }
        }

        field[0, 0] = 1;

        //field[boneCoords[0], boneCoords[1]] = 0;

        for (int i = 0; i < dogeEnemiesCoords.GetLength(0); i++)
        {
            field[dogeEnemiesCoords[i, 0], dogeEnemiesCoords[i, 1]] = -1;
        }
        return field;
    }
}