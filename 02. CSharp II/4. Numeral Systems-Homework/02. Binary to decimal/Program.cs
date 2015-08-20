using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your binary number.");
        Console.WriteLine(BinToDec(Console.ReadLine()));
    }

    static int BinToDec(string bin)
    {
        int dec = 0;
        for (int i = 0; i < bin.Length; i++)
        {
            int digit = bin[i] - '0';
            int pos = bin.Length - (i + 1);
            dec += digit * (int)Math.Pow(2, pos);
        }
        return dec;
    }
}