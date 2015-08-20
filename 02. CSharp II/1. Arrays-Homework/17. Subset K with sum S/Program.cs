using System;
using System.Collections.Generic;
using System.Text;
//Write a program that reads three integer numbers  N ,  K  and  S  
//and an array of  N  elements from the console.
//• Find in the array a subset of  K  elements that have sum  S  or indicate about its absence.
class Program
{
    static int sumToFind = 5;
    static int k = 3;
    static Stack<int> stack = new Stack<int>();
    static int tempSum = 0;

    //static int[] inputNumbers = { 2, 1, 2, 4, 3, 5, 2, 6 };

    static void Main()
    {
        Console.WriteLine("Enter a number for length of array:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of elements that will make up the sum:");
        k = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the sum we a searching for:");
        sumToFind = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} numbers, each on a new line.", n);

        int[] inputNumbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            inputNumbers[i] = int.Parse(Console.ReadLine());
        }

        RecursiveCalc(inputNumbers, 0, inputNumbers.Length);
    }

    static void RecursiveCalc(int[] data, int startIndex, int endIndex)
    {
        for (int i = startIndex; i < endIndex; i++)
        {
            stack.Push(data[i]);
            tempSum += data[i];
            RecursiveCalc(data, i + 1, endIndex);
            tempSum -= stack.Pop();
        }
        if (tempSum == sumToFind && stack.Count==k)
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