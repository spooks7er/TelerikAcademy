using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string number = Console.ReadLine();

        string[] splitnumber = number.Split(' ');
        
        double sum = 0;
        
        for (int i = 0; i < splitnumber.Length; i++)
        {
            sum +=  double.Parse(splitnumber[i]);
        }

        Console.WriteLine(sum);
    }
}