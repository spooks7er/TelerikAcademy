using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        string line = Console.ReadLine();

        List<int> bunnyCages = new List<int>();

        while (line != "END")
        {
            if (line != "END")
            {
                bunnyCages.Add(int.Parse(line));
            }
            line = Console.ReadLine();
        }

        int cicle = 1;
        while (true)
        {
            if (cicle > bunnyCages.Count)
            {
                break;
            }

            int firstCagesSum = 0;

            for (int i = 0; i < cicle; i++)
            {
                firstCagesSum += bunnyCages[i];
            }

            if ((firstCagesSum + cicle) > bunnyCages.Count)
            {
                break;
            }

            BigInteger sum = 0;
            BigInteger prod = 1;

            for (int i = 0; i < firstCagesSum; i++)
            {
                sum += bunnyCages[i + cicle];
                prod *= bunnyCages[i + cicle];
            }

            int usedCages = cicle + firstCagesSum;

            string sumStr = sum.ToString();
            string prodStr = prod.ToString();

            ///
            string newCages = sumStr + prodStr;

            for (int i = usedCages; i < bunnyCages.Count; i++)
            {
                newCages += bunnyCages[i];
            }

            bunnyCages.Clear();

            bunnyCages = newCages
                .Where(c => c != '0' && c != '1')
                .Select(c => c - '0')
                .ToList();
            ///

            //// tova raboti ////
            //for (int i = 0; i < usedCages; i++)
            //{
            //    bunnyCages.RemoveAt(0);
            //}
            /////////////////////

            //for (int i = prodStr.Length-1; i >= 0; i--)
            //{
            //    if (!(prodStr[i]=='0' || prodStr[i]=='1'))
            //    {
            //        bunnyCages.Insert(0, prodStr[i] - '0');
            //    }
            //}

            //for (int i = sumStr.Length - 1; i >= 0; i--)
            //{
            //    if (!(sumStr[i] == '0' || sumStr[i] == '1'))
            //    {
            //        bunnyCages.Insert(0, sumStr[i] - '0');
            //    }
            //}
            cicle++;
        }
        PrintResult(bunnyCages);
    }

    static void PrintResult(List<int> list)
    {
        string fff = string.Join(" ", list);
        Console.WriteLine(fff);
    }

}