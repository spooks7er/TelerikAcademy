using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        string bin = "10111";
        Console.WriteLine(BinToHex(bin));
    }

    private static readonly Dictionary<string, char> binStringToHex = new Dictionary<string, char> {
    { "0000", '0' },
    { "0001", '1' },
    { "0010", '2' },
    { "0011", '3' },
    { "0100", '4' },
    { "0101", '5' },
    { "0110", '6' },
    { "0111", '7' },
    { "1000", '8' },
    { "1001", '9' },
    { "1010", 'A' },
    { "1011", 'B' },
    { "1100", 'C' },
    { "1101", 'D' },
    { "1110", 'E' },
    { "1111", 'F' }
};

    public static string BinToHex(string bin)
    {
        if (bin.Length % 4 != 0)
        {
            bin = new string('0', 4 - bin.Length % 4) + bin;
        }
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < bin.Length; i += 4)
        {
            result.Append(binStringToHex[bin.Substring(i, 4)]);
        }
        return result.ToString();
    }
}