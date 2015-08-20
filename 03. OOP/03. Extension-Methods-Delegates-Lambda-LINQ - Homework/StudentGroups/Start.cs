using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentGroups
{
	class Start
	{
		public static void Main(string[] args)
		{
			Group g1 = new Group(1, Department.Physics);
			Group g2 = new Group(2, Department.Mathematics);
			
			var students = new List<Student>{
				new Student("Asen", "Bachev", 17, "101105","0879879", "asd@abv.bg", g1),
				new Student("Boiko", "Antonov", 18, "102105","0879879", "asdd@mail.bg", g1),
				new Student("Zvetelina", "Chipeva", 19, "203206","0879879", "asda@abv.bg", g2),
				new Student("Cvetan", "Dikov", 20, "204206","029586868", "asd@mail.bg", g2),
				new Student("Dobrinka", "Buchkova", 21, "205206","0879879", "asdq@abv.bg", g2)
			};
			students[0].Marks.Add(6);
			students[0].Marks.Add(4);

			students[1].Marks.Add(6);
			students[1].Marks.Add(2);

			students[2].Marks.Add(3);
			students[2].Marks.Add(2);

			students[3].Marks.Add(4);
			students[3].Marks.Add(2);

			students[4].Marks.Add(2);
			students[4].Marks.Add(2);

			Console.WriteLine("All Students from the list\n");

			foreach (var item in students)
			{
				Console.WriteLine(item.ToString());
				Console.WriteLine();
			}



			//10.
			Console.WriteLine("Students from Group 2 \n");
			//var studsFromG2 = from s in students
			//                  where s.GroupN == 2
			//                  orderby s.Fname
			//                  select s;
			var studsFromG2 = students
				.Where(s => s.GroupNumber.GroupNumber == 2)
				.OrderBy(s => s.Fname);

			foreach (var item in studsFromG2)
			{
				Console.WriteLine(item.ToString());
				Console.WriteLine();
			}

			//11.
			string searchEmail = "abv.bg";
			var emailinABV = students
				.Where(s => s.Email.Substring(s.Email.Length - searchEmail.Length, searchEmail.Length) == searchEmail)
				.Select(s => s);

            Console.WriteLine("Students with emails in abv.bg\n");
            foreach (var item in emailinABV)
			{
				Console.WriteLine(item.ToString());
				Console.WriteLine();
			}

			//12.
			string searchPhoneCode = "02";
			var phonesInSofia = students
				.Where(s => s.Tel.Substring(0,2) == searchPhoneCode)
				.Select(s => s);

            Console.WriteLine("Students with phones in Sofia\n");
            foreach (var item in phonesInSofia)
			{
				Console.WriteLine(item.ToString());
				Console.WriteLine();
			}
			
			
			
			//13.
			//var studsithExlMarks =
			//                from s in students
			//                where s.Marks.Contains(6)
			//                select new
			//                {
			//                    FullName = string.Format("{0} {1}", s.Fname, s.Lname),
			//                    MarksList = s.Marks
			//                };

			var studsithExlMarks = students
				.Where(s => s.Marks.Contains(6))
				.Select(s => new
				        {
				        	FullName = string.Format("{0} {1}", s.Fname, s.Lname),
				        	MarksList = s.Marks
				        });

            Console.WriteLine("Students with marks 6\n");
            foreach (var student in studsithExlMarks)
			{
				Console.WriteLine("Full name: {0}", student.FullName);
				Console.WriteLine("Marks: {0}", string.Join(", ", student.MarksList));
				Console.WriteLine();
			}

			//14.
			var studsWithTwoTwos = students.Where(s => s.Marks.FindAll(m => m == 2).Count == 2).
				Select(s => new
				       {
				       	FullName = string.Format("{0} {1}", s.Fname, s.Lname),
				       	MarksList = s.Marks
				       });

            Console.WriteLine("Students with two marks 2\n");
            foreach (var student in studsWithTwoTwos)
			{
				Console.WriteLine("Full name: {0}", student.FullName);
				Console.WriteLine("Marks: {0}", string.Join(", ", student.MarksList));
				Console.WriteLine();
			}

			//15.
			var studsFrom2006 = students
				.Where(s => s.Fnumber.Substring(4, 2) == "06")
				.Select(s => s);

            Console.WriteLine("Students from 2006\n");
			foreach (var item in studsFrom2006)
			{
				Console.WriteLine(item.ToString());
				Console.WriteLine();
			}
			
			//16.
			var bygroupName =
				//from s in students
				//where s by s.GroupNumber.DepartmentName == Department.Mathematics
				//select s;
				students
				.Where(s => s.GroupNumber.DepartmentName == Department.Mathematics)
				.Select(s => s);

            Console.WriteLine("Students in dept Mathematics\n");
			foreach (var item in bygroupName)
			{
				Console.WriteLine(item.ToString());
				Console.WriteLine();
			}

			//18. 19.
			var bygroupNum =
				//from s in students
				//group s by s.GroupNumber.GroupNumber into g
				//select new { Group = g.Key, Students = g.ToList() };
				students
				.GroupBy(s => s.GroupNumber.GroupNumber)
				.Select(s => new
				        {
				        	Group = s.Key,
				        	Students = s.ToList()
				        });

            Console.WriteLine("Students grouped by group number\n");
			foreach (var item in bygroupNum)
			{
				Console.WriteLine("Group Number - {0}\n", item.Group);
				Console.WriteLine(string.Join("\n", item.Students));
			}
		}
	}
}