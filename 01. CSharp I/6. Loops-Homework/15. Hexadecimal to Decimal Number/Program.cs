using System;
//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//• The input is entered as string. The output should be a variable of type long.
//• Do not use the built-in .NET functionality.
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        long decimalNumber = 0;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            int dec = 0;
            if (input[i] >= '0' && input[i] <= '9')
            {
                dec = input[i] - '0';
            }
            else
            {
                dec = input[i] - 'A' + 10;
            }

            switch (input[i])
            {
                case '0': decimalNumber = decimalNumber + (long.Parse(input[i].ToString())) * (long)Math.Pow(16, input.Length - 1 - i); break;
                case '1': decimalNumber = decimalNumber + (long.Parse(input[i].ToString())) * (long)Math.Pow(16, input.Length - 1 - i); break;
                case '2': decimalNumber = decimalNumber + (long.Parse(input[i].ToString())) * (long)Math.Pow(16, input.Length - 1 - i); break;
                case '3': decimalNumber = decimalNumber + (long.Parse(input[i].ToString())) * (long)Math.Pow(16, input.Length - 1 - i); break;
                case '4': decimalNumber = decimalNumber + (long.Parse(input[i].ToString())) * (long)Math.Pow(16, input.Length - 1 - i); break;
                case '5': decimalNumber = decimalNumber + (long.Parse(input[i].ToString())) * (long)Math.Pow(16, input.Length - 1 - i); break;
                case '6': decimalNumber = decimalNumber + (long.Parse(input[i].ToString())) * (long)Math.Pow(16, input.Length - 1 - i); break;
                case '7': decimalNumber = decimalNumber + (long.Parse(input[i].ToString())) * (long)Math.Pow(16, input.Length - 1 - i); break;
                case '8': decimalNumber = decimalNumber + (long.Parse(input[i].ToString())) * (long)Math.Pow(16, input.Length - 1 - i); break;
                case '9': decimalNumber = decimalNumber + (long.Parse(input[i].ToString())) * (long)Math.Pow(16, input.Length - 1 - i); break;
                case 'A': decimalNumber = decimalNumber + 10 * (long)Math.Pow(16, input.Length - 1 - i); break;
                case 'B': decimalNumber = decimalNumber + 11 * (long)Math.Pow(16, input.Length - 1 - i); break;
                case 'C': decimalNumber = decimalNumber + 12 * (long)Math.Pow(16, input.Length - 1 - i); break;
                case 'D': decimalNumber = decimalNumber + 13 * (long)Math.Pow(16, input.Length - 1 - i); break;
                case 'E': decimalNumber = decimalNumber + 14 * (long)Math.Pow(16, input.Length - 1 - i); break;
                case 'F': decimalNumber = decimalNumber + 15 * (long)Math.Pow(16, input.Length - 1 - i); break;
            }
        }
        Console.WriteLine(decimalNumber);
    }
}