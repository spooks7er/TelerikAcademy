using System;
//Using loops write a program that converts a binary integer number to its decimal form.
//• The input is entered as string. The output should be a variable of type long.
//• Do not use the built-in .NET functionality.
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] myString = input.ToCharArray();
        int result = 0;
        for (int i = 0; i < myString.Length; i++)
        {
            if (myString[myString.Length - (i + 1)] == '1')
            {
                result += (int)Math.Pow(2, i);
            }
        }
        Console.WriteLine(result);
    }
}