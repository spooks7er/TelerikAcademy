using System;
using System.Globalization;
//Problem 16. Date difference
//• Write a program that reads two dates in the format:  day.month.year
//and calculates the number of days between them.

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Enter the first date - d.MM.yyyy");
        //DateTime date1 = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);
        //Console.WriteLine("Enter the second date - d.MM.yyyy");
        //DateTime date2 = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);


        DateTime date1 = DateTime.ParseExact("27.02.2006", "d.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime date2 = DateTime.ParseExact("3.03.2006", "d.MM.yyyy", CultureInfo.InvariantCulture);

        double days = Math.Abs((date1 - date2).TotalDays);
        Console.WriteLine("{0} days",days);
    }
}