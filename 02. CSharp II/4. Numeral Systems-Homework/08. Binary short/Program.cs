using System;
class BinShort
{
    static void Main()
    {
        Console.WriteLine("Enter a number in between {0} and {1}.", short.MinValue, short.MaxValue);
        short number = short.Parse(Console.ReadLine());

        Console.WriteLine("{0} to binary =>{1}", number, ConvertToBinary(number));
    }

    static string ConvertToBinary(int number)
    {
        string binary = string.Empty;
        for (int i = 15; i >= 0; i--)
        {
            binary = ((number % 2) & 1) + binary;
            number >>= 1;

            if (i % 4 == 0) binary = " " + binary;
        }
        return binary;
    }
}
