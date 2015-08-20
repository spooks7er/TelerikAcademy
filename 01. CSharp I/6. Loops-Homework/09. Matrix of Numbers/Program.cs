using System;
//Write a program that reads from the console a positive integer number  n  
//(1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.
class Program
{
    static void Main(string[] args)
    {
        int n = 0;
        do
        {
            n = int.Parse(Console.ReadLine());
        } while (!(n >= 1 && n <= 20));
        int[,] array = new int[n, n];
        int num = 1;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = num;
                num++;
                Console.Write("{0}  ", array[i, j]);
            }
            Console.WriteLine();
        }
    }
}