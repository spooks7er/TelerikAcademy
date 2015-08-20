using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your number. Use any numeral system.");
        string test = Console.ReadLine();

        Console.WriteLine("Enter current numeral system.");
        int from = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter output numeral system.");

        int to = int.Parse(Console.ReadLine());

        Console.WriteLine(BaseToBase(test, from, to));
    }

    static string BaseToBase(string numeral, int fromBase, int toBase)
    {
        return DecToBase(BaseToDec(numeral, fromBase), toBase);
    }

    static int BaseToDec(string numeral, int nBase)
    {
        int dec = 0;
        for (int i = 0; i < numeral.Length; i++)
        {
            int digit = 0;
            if (numeral[i] >= '0' && numeral[i] <= '9')
            {
                digit = numeral[i] - '0';
            }
            else if (numeral[i] >= 'A' && numeral[i] <= 'Z')
            {
                digit = numeral[i] - 'A' + 10;
            }
            else if (numeral[i] >= 'a' && numeral[i] <= 'z')
            {
                digit = numeral[i] - 'a' + 10;
            }
            dec += digit * (int)Math.Pow(nBase, numeral.Length - i - 1);
        }
        return dec;
    }

    static string DecToBase(int dec, int nBase)
    {
        string result = string.Empty;
        while (dec > 0)
        {
            int digit = dec % nBase;
            if (digit >= 0 && digit <= 9)
            {
                result = digit + result;
            }
            else if (digit >= 10 && digit <= 15)
            {
                result = (char)(digit - 10 + 'A') + result;
            }
            dec /= nBase;
        }
        return result;
    }
}