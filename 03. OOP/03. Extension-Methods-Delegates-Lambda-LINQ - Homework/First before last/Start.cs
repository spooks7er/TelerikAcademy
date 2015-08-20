using System;
using System.Linq;
using System.Collections.Generic;

namespace Students
{
    class Start
    {
        public static void Main(string[] args)
        {
            Student[] students = {
				new Student("Asen", "Bachev", 17),
				new Student("Boiko", "Antonov", 18),
				new Student("Antonia", "Chipeva", 19),
				new Student("Cvetan", "Dikov", 20),
				new Student("Dobrinka", "Buchkova", 21)
			};
            Console.WriteLine("All Students\n");
            foreach (var item in students)
            {
                Console.WriteLine("{0} {1} - {2}", item.FName, item.LName, item.Age);
            }

            // 03.
            var firstBeforeLast = students.FirstBeforeLast();
            Console.WriteLine("\nFirst Name before last name\n");
            foreach (var item in firstBeforeLast)
            {
                Console.WriteLine("{0} {1} - {2}", item.FName, item.LName, item.Age);
            }

            // 04.
            var ageRange = students.AgeRange(18, 24);
            Console.WriteLine("\nAge range 18 - 24\n");
            foreach (var item in ageRange)
            {
                Console.WriteLine(item);
            }

            // 05.
            var orderedDesc = students
                .OrderByDescending(s => s.FName)
                .ThenByDescending(s => s.FName);

            var orderedDescLINQ =
                from s in students
                orderby s.FName descending, s.LName descending
                select s;
            Console.WriteLine("\nOrdered by name descending\n");
            foreach (var item in orderedDescLINQ)
            {
                Console.WriteLine("{0} {1} - {2}", item.FName, item.LName, item.Age);
            }
        }
    }

    static class Extensions
    {
        public static IEnumerable<Student> FirstBeforeLast(this Student[] st)
        {
            return st
                .Where(s => s.FName.CompareTo(s.LName) == -1);
        }

        public static IEnumerable<string> AgeRange(this Student[] st, int lower, int upper)
        {
            //			return st
            //				.Where(s => s.Age >= lower && s.Age <= upper)
            //				.Select(s => s.fName+" "+s.lName + " - " + s.Age);

            return
                from s in st
                where s.Age >= lower && s.Age <= upper
                select s.FName + " " + s.LName + " - " + s.Age;
        }
    }
}