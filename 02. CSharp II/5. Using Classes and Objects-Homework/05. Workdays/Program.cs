using System;
using System.Linq;

//Write a method that calculates the number of workdays between today 
//and given date, passed as parameter.
//• Consider that workdays are all days from Monday to Friday except a 
// fixed list of public holidays specified preliminary as array.
class Program
{
    public static DateTime[] publicHolidays = new DateTime[]
                            {
                                new DateTime(2015, 1, 1),
                                new DateTime(2015, 3, 2),
                                new DateTime(2015, 3, 3),
                                new DateTime(2015, 4, 10),
                                new DateTime(2015, 4, 11),
                                new DateTime(2015, 4, 12),
                                new DateTime(2015, 4, 13),
                                new DateTime(2015, 5, 1),
                                new DateTime(2015, 9, 21),
                                new DateTime(2015, 9, 22),
                                new DateTime(2015, 12, 24),
                                new DateTime(2015, 12, 25),
                                new DateTime(2015, 12, 26),
                                new DateTime(2015, 12, 31),
                            };

    static void Main()
    {
        WorkDays();

    }

    private static void WorkDays()
    {
        DateTime today = DateTime.Today;
        DateTime date = Convert.ToDateTime(Console.ReadLine());
        //DateTime date = new DateTime(2015, 4, 14);
        int daysInBetween = (date - today).Days;
        DateTime cc = today;
        int count = 0;
        for (int i = 1; i <= daysInBetween; i++)
        {
            if ((cc.AddDays(i).DayOfWeek.ToString() != "Saturday" && 
                cc.AddDays(i).DayOfWeek.ToString() != "Sunday") && 
                !publicHolidays.Contains(cc.AddDays(i)))
            {
                //Console.WriteLine(cc.AddDays(i).ToString("d"));
                count++;
            }
        }
        Console.WriteLine(count);
    }
}