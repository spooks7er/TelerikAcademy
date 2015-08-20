using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Matrix_class
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] a = {{1,2},
            //            {3,4},
            //            {5,6}};

            //int[,] b = {{1,2,3,4},
            //            {5,6,7,8}};
            //int[,] a = {{1,2,3},
            //            {4,5,6}};

            //int[,] b = {{7,8},
            //            {9,10},
            //            {11,12}};

            int[,] a = {{3,8},
                        {4,6}};

            int[,] b = {{4,0},
                        {1,-9}};

            for (int r = 0; r < a.GetLength(0); r++)
            {
                for (int c = 0; c < b.GetLength(1); c++)
                {
                    Console.Write("{0} ", Matrix.Add(a, b)[r, c]);
                }
                Console.WriteLine();
            }
        }
    }

    class Matrix
    {
        public static int[,] Add(int[,] a, int[,] b)
        {
            int[,] matrixAB = new int[a.GetLength(0), b.GetLength(1)];

            if (a.GetLength(0) != b.GetLength(0) && a.GetLength(1) != b.GetLength(1))
            {
                Console.WriteLine("Matrices cannot be subtracted.");
                return matrixAB;
            }

            for (int r = 0; r < matrixAB.GetLength(0); r++)
            {
                for (int c = 0; c < matrixAB.GetLength(1); c++)
                {
                    matrixAB[r, c] = a[r, c] + b[r, c];
                }
            }
            return matrixAB;
        }

        public static int[,] Subtract(int[,] a, int[,] b)
        {
            int[,] matrixAB = new int[a.GetLength(0), b.GetLength(1)];

            if (a.GetLength(0) != b.GetLength(0) && a.GetLength(1) != b.GetLength(1))
            {
                Console.WriteLine("Matrices cannot be subtracted.");
                return matrixAB;
            }

            for (int r = 0; r < matrixAB.GetLength(0); r++)
            {
                for (int c = 0; c < matrixAB.GetLength(1); c++)
                {
                    matrixAB[r, c] = a[r, c] - b[r, c];
                }
            }
            return matrixAB;
        }

        public static int[,] Multiply(int[,] a, int[,] b)
        {
            int[,] matrixAB = new int[a.GetLength(0), b.GetLength(1)];

            if (a.GetLength(1) != b.GetLength(0))
            {
                Console.WriteLine("Matrices cannot be multiplied.");
                return matrixAB;
            }

            for (int r = 0; r < matrixAB.GetLength(0); r++)
            {
                for (int c = 0; c < matrixAB.GetLength(1); c++)
                {
                    int value = 0;
                    for (int i = 0; i < a.GetLength(1); i++)
                    {
                        value += a[r, i] * b[i, c];
                    }
                    matrixAB[r, c] = value;
                }
            }
            return matrixAB;
        }
    }
}
