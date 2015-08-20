using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsAndWorkers
{
    class StartHere
    {
        public static void Main(string[] args)
        {
            var studList = new List<Student>
			{
				new Student("Ivan", "Shopov", 3.5),
				new Student("Petar", "Georgiev", 5.5),
				new Student("Kristina", "Kirilova", 6),
				new Student("Asen", "Bachev", 4.6),
				new Student("Boiko", "Antonov", 5.3),
				new Student("Zvetelina", "Chipeva", 3.2),
				new Student("Cvetan", "Dikov", 2),
				new Student("Dobrinka", "Buchkova", 6),
				new Student("Kiril", "Sevdelinov", 5),
				new Student("Sminduh", "Zahariev", 4)
			};

            var workerList = new List<Worker>
			{
				new Worker("Petar", "Kerchev", 275, 9),
				new Worker("Ivan", "Kostov", 850, 10),
				new Worker("Madlen", "Caneva", 460, 9),
				new Worker("Bojidar", "Lukarski", 500, 8),
				new Worker("Boiko", "Borisov", 1300, 9),
				new Worker("Shmirgel", "Paskalev", 120, 8),
				new Worker("Hanko", "Brat", 50, 5),
				new Worker("Gerasim", "Kabulkov", 136.98m, 7),
				new Worker("Kiril", "Sevdelinov", 120, 4),
				new Worker("Sminduh", "Zahariev", 120, 4)
			};

            var studsByGradeAsc = studList
                .OrderBy(s => s.Grade)
                .ToList();
            Console.WriteLine("This is the list of students ordered by grade\n");
            foreach (var element in studsByGradeAsc)
            {
                Console.WriteLine("{0} {1} - {2:F2}", element.FName, element.LName, element.Grade);
            }

            var workersByMoneyPerHourDesc = workerList
                .OrderByDescending(w => w.MoneyPerHour())
                .ToList();
            Console.WriteLine("\nThis is the list of workers ordered by Money Per Hour\n");
            foreach (var element in workersByMoneyPerHourDesc)
            {
                Console.WriteLine("{0} {1} - {2:F2}", element.FName, element.LName, element.MoneyPerHour());
            }

            var allTogether = studList
                .Concat<Human>(workerList)
                .OrderBy(a => a.FName)
                .ThenBy(a => a.LName)
                .ToList();
            Console.WriteLine("\nThis is the combined list ordered by Name\n");
            foreach (var element in allTogether)
            {
                Console.WriteLine("{0} {1}", element.FName, element.LName);
            }
        }
    }
}