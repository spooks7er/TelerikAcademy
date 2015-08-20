using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your decimal number.");
        Console.WriteLine(DecToHex(int.Parse(Console.ReadLine())));
    }

    static string DecToHex(int dec)
    {
        string result = string.Empty;
        while (dec > 0)
        {
            int digit = dec % 16;
            if (digit >= 0 && digit <= 9)
            {
                result = digit + result;
            }
            else if (digit >= 10 && digit <= 15)
            {
                result = (char)(digit - 10 + 'A') + result;
            }
            dec /= 16;
        }
        return result;
    }
}