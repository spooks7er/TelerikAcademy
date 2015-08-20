using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
//Problem 19. Dates from text in Canada
//• Write a program that extracts from a given text all dates that match the format DD.MM.YYYY .
//• Display them in the standard date format for Canada.
class Program
{
    static void Main(string[] args)
    {
        string text = "07.06.2011 asd asd 04.7.2009 ads asd  5.8.2005 adsasd as 1.12.2015";

        string format = "dd.MM.yyyy";

        CultureInfo canada = new CultureInfo("fr-CA");

        foreach (var match in Regex.Matches(text, @"[\d]{2,2}.[\d]{2,2}.[\d]{4}"))
        {
            DateTime check = DateTime.ParseExact(match.ToString(), format, CultureInfo.InvariantCulture);
            Console.WriteLine(check.ToString("d", canada));
        }
    }
}