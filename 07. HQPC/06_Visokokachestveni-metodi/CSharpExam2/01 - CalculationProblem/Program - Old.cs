using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
//01 -  CalculationProblem
// grrrr miao miao
class Program_Old
{
    static void Main_old(string[] args)
    {
        string input = Console.ReadLine();

        string[] numbersBase23 = input
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        int[] numbersBase10 = new int[numbersBase23.Length];

        string result = "";
        int power = 0;

        for (int i = 0; i < numbersBase23.Length; i++)
        {
            for (int j = 0; j < numbersBase23[i].Length; j++)
            {
                int digit = 0;
                if (numbersBase23[i][j] >= 'a' && numbersBase23[i][j] <= 'w')
                {
                    digit = numbersBase23[i][j] - 'a';
                }
                numbersBase10[i] += digit * (int)Math.Pow(23, numbersBase23[i].Length - j - 1);
            }
        }

        int sum = 0;

        for (int i = 0; i < numbersBase10.Length; i++)
        {
            sum += numbersBase10[i];
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