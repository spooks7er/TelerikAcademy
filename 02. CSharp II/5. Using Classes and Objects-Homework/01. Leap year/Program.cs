using System;
//• Write a program that reads a year from the console and checks whether it is a leap one.
//• Use  System.DateTime .
class Program
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());
        bool isLeap = DateTime.IsLeapYear(year);

        if (isLeap)
        {
            Console.WriteLine("The year {0} is a leap year", year);
        }
        else
        {
            Console.WriteLine("The year {0} is not a leap year", year);
        }
        Main();
    }
}