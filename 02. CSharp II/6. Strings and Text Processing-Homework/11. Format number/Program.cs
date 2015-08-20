using System;
using System.Text;

//Problem 11. Format number
//• Write a program that reads a number and prints it as a decimal number, 
//  hexadecimal number, percentage and in scientific notation.
//• Format the output aligned right in 15 symbols.
class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        string[] formatStrings = { "F2", "X", "P", "E" };

        foreach (string fString in formatStrings)
        {
            Console.WriteLine("{0,15:"+fString+"}", number);
        }
    }
}