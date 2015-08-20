using System;
using System.Collections.Generic;
using System.Text;
//We are given an array of integers and a number S. Write a
//program to find if there exists a subset of the elements of the array that has a sum S.
//Example:	arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)
class Program
{   
    static int sumToFind = 14;
    static Stack<int> stack = new Stack<int>();
    static int tempSum = 0;

    static int[] inputNumbers = { 2, 1, 2, 4, 3, 5, 2, 6 };

    static void Main()
    {
        //Console.WriteLine("Enter a number for length of array:");
        //int n = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter the sum we a searching for:");
        //sumToFind = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter {0} numbers, each on a new line.", n);
       
        //int[] inputNumbers = new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    inputNumbers[i] = int.Parse(Console.ReadLine());
        //}

        RecursiveCalc(inputNumbers, 0, inputNumbers.Length);
    }

    static void RecursiveCalc(int[] data, int startIndex, int endIndex)
    {
        for (int currentIndex = startIndex; currentIndex < endIndex; currentIndex++)
        {
            stack.Push(data[currentIndex]);
            tempSum += data[currentIndex];
            RecursiveCalc(data, currentIndex + 1, endIndex);
            tempSum -= stack.Pop();
        }
        if (tempSum == sumToFind)
        {
            printSet(stack);
        }
    }//end of RecursiveCalc()

    static void printSet(Stack<int> stack)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(sumToFind).Append(" = ");
        foreach (int value in stack)
        {
            sb.Append(value).Append("+");
        }
        sb.Length--;
        if (sb.Length < 4) return;
        Console.WriteLine(sb.ToString());
    }// end of printSet()
}