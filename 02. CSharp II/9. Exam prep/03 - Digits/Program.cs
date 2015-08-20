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
        int pattH = 5;
        int pattL = 3;

        int zeros = 0;
        int ones = 0;
        int twos = 0;
        int threes = 0;
        int fours = 0;
        int fives = 0;
        int sixes = 0;
        int sevens = 0;
        int eights = 0;
        int nines = 0;

        int sum = 0;

        for (int i = 0; i <= matrix.GetLength(0) - pattH; i++)
        {
            for (int j = 0; j <= matrix.GetLength(1) - pattL; j++)
            {
                //zeros
                //ones
                if (matrix[i + 2, j] == 1
                    && matrix[i + 2, j + 0] == matrix[i + 1, j + 1]
                    && matrix[i + 1, j + 1] == matrix[i + 0, j + 2]
                    && matrix[i + 0, j + 2] == matrix[i + 1, j + 2]
                    && matrix[i + 1, j + 2] == matrix[i + 2, j + 2]
                    && matrix[i + 2, j + 2] == matrix[i + 3, j + 2]
                    && matrix[i + 3, j + 2] == matrix[i + 4, j + 2]
                    )
                {
                    ones++;
                }
                //twos
                if (matrix[i, j] == 2
                    && matrix[i + 1, j + 0] == matrix[i + 0, j + 1]
                    && matrix[i + 0, j + 1] == matrix[i + 1, j + 2]
                    && matrix[i + 1, j + 2] == matrix[i + 2, j + 2]
                    && matrix[i + 2, j + 2] == matrix[i + 3, j + 1]
                    && matrix[i + 3, j + 1] == matrix[i + 4, j + 0]
                    && matrix[i + 4, j + 0] == matrix[i + 4, j + 1]
                    && matrix[i + 4, j + 1] == matrix[i + 4, j + 2]
                    )
                {
                    twos++;
                }
                //threes

                ///.....and so on
            }
        }
        sum = ones*1 + twos*2 + threes*3 + fours*4 + fives*5 + sixes*6 + sevens*7 + eights*8 + nines*9;

        Console.WriteLine(sum);
        
    }

    static void PrinMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,2}", matrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}