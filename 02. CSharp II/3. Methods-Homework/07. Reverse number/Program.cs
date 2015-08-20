using System;
using System.Globalization;
using System.Threading;
//Write a method that reverses the digits of given decimal number.
class Program
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter a Decimal Number (use DOT \".\" for decimal point)");
        string asd = Console.ReadLine();
        decimal dsa = Reversed(asd);
        Console.WriteLine(dsa);
    }
    static decimal Reversed(string dec)
    {
        char[] charArray = dec.ToCharArray();
        Array.Reverse(charArray);
        dec = new string(charArray);
        decimal res = decimal.Parse(dec);
        return res;
    }
}