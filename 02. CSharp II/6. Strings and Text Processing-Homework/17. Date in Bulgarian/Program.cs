using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 17. Date in Bulgarian
//• Write a program that reads a date and time given in the format:
//day.month.year hour:minute:second  and prints the date and time 
//after  6  hours and  30  minutes (in the same format) along with the day of week in Bulgarian.
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        string formatString = "d.MM.yyyy HH:mm:ss";

        Console.WriteLine("Enter date - "+formatString+" (2.05.2015 17:45:28)");

        DateTime date1 = DateTime.ParseExact(Console.ReadLine(), formatString, CultureInfo.InvariantCulture);

        //DateTime date1 = DateTime.ParseExact("2.05.2015 17:45:28", formatString, CultureInfo.InvariantCulture);

        date1 = date1.AddHours(6).AddMinutes(30);
        CultureInfo bulgarian = new CultureInfo("bg-BG");
        string dayName = bulgarian.DateTimeFormat.GetDayName(date1.DayOfWeek); ;

        Console.WriteLine("{0} {1}", date1.ToString(formatString), UppercaseFirst(dayName));
    }
    static string UppercaseFirst(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return string.Empty;
        }
        char[] a = s.ToCharArray();
        a[0] = char.ToUpper(a[0]);
        return new string(a);
    }
}