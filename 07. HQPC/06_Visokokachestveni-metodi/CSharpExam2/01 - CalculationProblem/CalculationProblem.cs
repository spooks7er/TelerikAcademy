using System;
using System.Linq;

//01 -  CalculationProblem
// grrrr miao miao
public class CalculationProblem
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] numbersBase23 = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        int[] numbersBase10 = new int[numbersBase23.Length];

        for (int i = 0; i < numbersBase23.Length; i++)
        {
            numbersBase10[i] = Base23ToBase10(numbersBase23[i]);
        }

        int sumBase10 = 0;

        for (int i = 0; i < numbersBase10.Length; i++)
        {
            sumBase10 += numbersBase10[i];
        }

        string sumBase23 = Base10ToBase23(sumBase10);

        Console.WriteLine("{0} = {1}", sumBase23, sumBase10);
    }

    public static int Base23ToBase10(string base23Number)
    {
        int result = 0;

        for (int i = 0; i < base23Number.Length; i++)
        {
            int digit = base23Number[i] - 'a';

            result += digit * (int)Math.Pow(23, base23Number.Length - i - 1);
        }

        return result;
    }

    public static string Base10ToBase23(int base10Number)
    {
        string result = string.Empty;

        while (base10Number > 0)
        {
            int digit = base10Number % 23;
            result = (char)(digit + 'a') + result;
            base10Number /= 23;
        }

        return result;
    }
}