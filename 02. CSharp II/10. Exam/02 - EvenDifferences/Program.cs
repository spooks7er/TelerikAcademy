using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

//1 6 8 10 3 1 1
class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        long[] inputInts = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
             .Select(long.Parse).ToArray();

        BigInteger evenDiffSum = 0;
        for (int i = 1; i < inputInts.Length; i++)
        {
            int jump = 0;
            BigInteger absDif = Math.Abs(inputInts[i] - inputInts[i - 1]);
            if (absDif == 0)
            {
                jump = 0;
            }
            else if (absDif % 2 == 0 && absDif != 0)
            {
                evenDiffSum += absDif;
                jump = 1;
            }
            else if (absDif % 2 != 0)
            {
                jump = 0;
            }
            i += jump;
            if (i > inputInts.Length - 1)
            {
                break;
            }
        }
        Console.WriteLine(evenDiffSum);
    }
}