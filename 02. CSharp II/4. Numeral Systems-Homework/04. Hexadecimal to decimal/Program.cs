using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your hex number.");
        Console.WriteLine(HexToDec(Console.ReadLine()));
    }

    static int HexToDec(string hex)
    {
        int dec = 0;
        for (int i = 0; i < hex.Length; i++)
        {
            int digit = 0;
            if (hex[i] >= '0' && hex[i] <= '9')
            {
                digit = hex[i] - '0';
            }
            else if (hex[i] >= 'A' && hex[i] <= 'Z')
            {
                digit = hex[i] - 'A' + 10;
            }
            else if (hex[i] >= 'a' && hex[i] <= 'z')
            {
                digit = hex[i] - 'a' + 10;
            }
            dec += digit * (int)Math.Pow(16, hex.Length - i - 1);
        }
        return dec;
    }
}