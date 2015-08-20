using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder input = new StringBuilder();
        string line = Console.ReadLine(); ;

        while (line != "END")
        {
            if (line != "END")
            {
                input.Append(line);
            }
            line = Console.ReadLine();
        }

        string allCages = input.ToString();
        int cicle = 1;
        while (true)
        {
            if (cicle > allCages.Length)
            {
                PrintResult(allCages);
                break;
            }
            int firstCagesSum = 0;

            string firstCages = allCages.Substring(0, cicle);

            int[] firstCagesInt = firstCages.ToCharArray().Select(n => n - '0').ToArray();


            for (int i = 0; i < firstCagesInt.Length; i++)
            {
                firstCagesSum += firstCagesInt[i];
            }

            if (firstCagesSum > allCages.Length)
            {
                PrintResult(allCages);
                break;
            }

            BigInteger sum = 0;
            BigInteger prod = 1;
            for (int i = 0; i < firstCagesSum; i++)
            {
                sum += allCages[i + cicle] - '0';
                prod *= allCages[i + cicle] - '0';
            }

            int usedCages = cicle + firstCagesSum;

            allCages = allCages.Remove(0, usedCages);

            allCages = sum.ToString() + prod.ToString() + allCages;
            allCages = allCages.Replace("0", "").Replace("1", "");
            cicle++;
        }
    }
    static void PrintResult(string final)
    {
        var finalOutput = final.ToCharArray();

        string fff = string.Join(" ", finalOutput);
        Console.WriteLine(fff);
    }
}