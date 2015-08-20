using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        var matrix = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < line.Length; j++)
            {
                matrix[i, j] = int.Parse(line[j]);
            }
        }
        int pattH = 3;
        int pattL = 5;

        bool isThereAPattern = false;
        long currSum = 0;
        long bestSum = 0;
        for (int i = 0; i <= matrix.GetLength(0) - pattH; i++)
        {
            for (int j = 0; j <= matrix.GetLength(1) - pattL; j++)
            {
                if (matrix[i, j] + 1 == matrix[i, j + 1]
                    && matrix[i, j + 1] + 1 == matrix[i, j + 2]

                    && matrix[i, j + 2] + 1 == matrix[i + 1, j + 2]
                    && matrix[i + 1, j + 2] + 1 == matrix[i + 2, j + 2]

                    && matrix[i + 2, j + 2] + 1 == matrix[i + 2, j + 3]
                    && matrix[i + 2, j + 3] + 1 == matrix[i + 2, j + 4]
                    )
                {
                    isThereAPattern = true;
                    currSum = matrix[i, j];
                    currSum += matrix[i, j + 1];
                    currSum += matrix[i, j + 2];
                    currSum += matrix[i + 1, j + 2];
                    currSum += matrix[i + 2, j + 2];
                    currSum += matrix[i + 2, j + 3];
                    currSum += matrix[i + 2, j + 4];
                }
                if (currSum >= bestSum)
                {
                    bestSum = currSum;
                }
            }
        }
        if (isThereAPattern)
        {
            Console.WriteLine("YES {0}", bestSum);
        }
        else
        {
            bestSum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                bestSum += matrix[i, i];
            }
            Console.WriteLine("NO {0}", bestSum);
        }
    }
}