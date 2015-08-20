using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your decimal number.");
        Console.WriteLine(DecToBin(int.Parse(Console.ReadLine())));
    }

    static string DecToBin(int dec)
    {
        string bin = string.Empty;
        while (dec > 0)
        {
            bin = dec % 2 + bin;
            dec /= 2;
        }
        return bin;
    }
}