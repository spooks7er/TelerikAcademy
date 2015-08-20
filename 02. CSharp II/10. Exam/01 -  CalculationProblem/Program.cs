using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
//01 -  CalculationProblem
// grrrr miao miao
class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        var allNumbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
             .ToArray();

        int[] numberDec = new int[allNumbers.Length];

        string result = "";
        int power = 0;
        for (int i = 0; i < allNumbers.Length; i++)
        {
            for (int j = 0; j < allNumbers[i].Length; j++)
            {
                int digit = 0;
                if (allNumbers[i][j] >= 'a' && allNumbers[i][j] <= 'w')
                {
                    digit = allNumbers[i][j] - 'a';
                }
                numberDec[i] += digit * (int)Math.Pow(23, allNumbers[i].Length - j - 1);
            }
        }

        int sum = 0;
        for (int i = 0; i < numberDec.Length; i++)
        {
            sum += numberDec[i];
        }
        int sumBack = sum;
        while (sum > 0)
        {
            int digit = sum % 23;
            result = (char)(digit + 'a') + result;
            sum /= 23;
        }


        Console.WriteLine("{0} = {1}", result, sumBack);

    }
    static BigInteger Power(int number, int power)
    {
        BigInteger result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= number;
        }
        return result;
    }

}