using System;
//Using loops write a program that converts an integer number to its hexadecimal representation.
//• The input is entered as long. The output should be a variable of type string.
//• Do not use the built-in .NET functionality.
class Program
{
    static void Main(string[] args)
    {
        long input = long.Parse(Console.ReadLine());
        string hexaDecimalNUmber = "";
        while (input >= 1)
        {
            switch (input % 16)
            {
                case 0: hexaDecimalNUmber = hexaDecimalNUmber + input % 16; break;
                case 1: hexaDecimalNUmber = hexaDecimalNUmber + input % 16; break;
                case 2: hexaDecimalNUmber = hexaDecimalNUmber + input % 16; break;
                case 3: hexaDecimalNUmber = hexaDecimalNUmber + input % 16; break;
                case 4: hexaDecimalNUmber = hexaDecimalNUmber + input % 16; break;
                case 5: hexaDecimalNUmber = hexaDecimalNUmber + input % 16; break;
                case 6: hexaDecimalNUmber = hexaDecimalNUmber + input % 16; break;
                case 7: hexaDecimalNUmber = hexaDecimalNUmber + input % 16; break;
                case 8: hexaDecimalNUmber = hexaDecimalNUmber + input % 16; break;
                case 9: hexaDecimalNUmber = hexaDecimalNUmber + input % 16; break;
                case 10: hexaDecimalNUmber = hexaDecimalNUmber + "A"; break;
                case 11: hexaDecimalNUmber = hexaDecimalNUmber + "B"; break;
                case 12: hexaDecimalNUmber = hexaDecimalNUmber + "C"; break;
                case 13: hexaDecimalNUmber = hexaDecimalNUmber + "D"; break;
                case 14: hexaDecimalNUmber = hexaDecimalNUmber + "E"; break;
                case 15: hexaDecimalNUmber = hexaDecimalNUmber + "F"; break;
            }
            input = input / 16;
        }
        string result = "";
        for (int i = hexaDecimalNUmber.Length - 1; i >= 0; i--)
        {
            result += hexaDecimalNUmber[i];
        }
        Console.WriteLine(result);
    }
}