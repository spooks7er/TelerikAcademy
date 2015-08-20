using System;
using System.Linq;

//1 6 8 10 3 1 1
class EvenDifferences
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        long[] inputInts = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

        long evenDiffSum = 0;

        for (int i = 1; i < inputInts.Length; i++)
        {
            long absDif = Math.Abs(inputInts[i] - inputInts[i - 1]);

            if (absDif % 2 == 0)
            {
                evenDiffSum += absDif;
                i++;
            }
        }

        Console.WriteLine(evenDiffSum);
    }
}