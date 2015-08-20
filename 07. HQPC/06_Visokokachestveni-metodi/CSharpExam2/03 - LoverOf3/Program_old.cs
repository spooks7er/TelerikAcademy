using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program_old
{
    static void Main_old(string[] args)
    {
        string firstLine = Console.ReadLine();

        var dims = firstLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse).ToArray();

        int dirNum = int.Parse(Console.ReadLine());

        var dirs = new List<string>();
        var steps = new List<int>();
        for (int i = 0; i < dirNum; i++)
        {
            string myString = Console.ReadLine();
            string dir = myString.Substring(0, 2);
            int times = int.Parse(myString.Substring(3));
            dirs.Add(dir);
            steps.Add(times);
        }

        int[,] matrix = new int[dims[0], dims[1]];
        int rowStart = 0;
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
        PrinMatrix(matrix);
        //o	RU and UR mean UP-RIGHT
        //o	LU and UL mean UP-LEFT
        //o	DL and LD mean DOWN-LEFT
        //o	DR and RD mean DOWN-RIGHT

        int curri = matrix.GetLength(0) - 1;
        int currj = 0;
        int sum = 0;
        for (int i = 0; i < dirs.Count; i++)
        {
            int stepsCount = 0;

            if (dirs[i] == "RU" || dirs[i] == "UR")
            {
                stepsCount = steps[i];
                for (int j = 0; j < stepsCount; j++)
                {
                    if ((curri < 0 || currj > matrix.GetLength(1) - 1))
                    {
                        break;
                    }

                    sum += matrix[curri, currj];
                    matrix[curri, currj] = 0;

                    curri--;
                    currj++;

                }
                curri++;
                currj--;
            }

            if (dirs[i] == "LU" || dirs[i] == "UL")
            {
                stepsCount = steps[i];
                for (int j = 0; j < stepsCount; j++)
                {
                    if ((curri < 0 || currj < 0))
                    {
                        break;
                    }

                    sum += matrix[curri, currj];
                    matrix[curri, currj] = 0;

                    curri--;
                    currj--;


                }
                curri++;
                currj++;
            }

            if (dirs[i] == "LD" || dirs[i] == "DL")
            {
                stepsCount = steps[i];
                for (int j = 0; j < stepsCount; j++)
                {
                    if ((curri > matrix.GetLength(0) - 1) || currj < 0)
                    {
                        break;
                    }

                    sum += matrix[curri, currj];
                    matrix[curri, currj] = 0;


                    curri++;
                    currj--;
                }
                curri--;
                currj++;
            }

            if (dirs[i] == "RD" || dirs[i] == "DR")
            {
                stepsCount = steps[i];
                for (int j = 0; j < stepsCount; j++)
                {
                    if ((curri > matrix.GetLength(0) - 1 || currj > matrix.GetLength(1) - 1))
                    {
                        break;
                    }

                    sum += matrix[curri, currj];
                    matrix[curri, currj] = 0;

                    curri++;
                    currj++;

                }
                curri--;
                currj--;
            }

            //Console.WriteLine(curri + " | " + currj);
        }

        Console.WriteLine(sum);
        //Console.WriteLine(curri+" | "+currj);
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