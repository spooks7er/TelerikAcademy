namespace AcademySystem.ConsoleClient
{
    using System;
    using System.Linq;
    using AcademySystem.Data;
    using AcademySystem.Models;

    public class SampleDataFiller
    {
        private static Random rand = new Random();

        public void FillSampleStudents()
        {
            using (var db = new AcademyDbContext())
            {
                for (int i = 1; i <= 60; i++)
                {
                    var st = new Student
                    {
                        FirstName = "Pesho " + i.ToString(),
                        LastName = "TEST " + i.ToString(),
                    };

                    db.Students.Add(st);
                }

                db.SaveChanges();
            }
        }

        public void FillSampleCoursesWithStudents()
        {
            using (var db = new AcademyDbContext())
            {
                var allStudents = db.Students.ToList();

                for (int i = 1; i <= 6; i++)
                {
                    var course = new Course
                    {
                        Name = "Course " + i.ToString(),
                        Description = new String('d', rand.Next(10, 200)),
                    };

                    for (int j = 0; j < rand.Next(1, 25 + 1); j++)
                    {
                        course.Students.Add(allStudents[rand.Next(0, 60)]);
                    }

                    db.Courses.Add(course);
                }

                db.SaveChanges();
            }
        }

        public void FillSampleHomeworks()
        {
            using (var db = new AcademyDbContext())
            {
                var allStudents = db.Students.ToList();
                var allCourses = db.Courses.ToList();

                for (int i = 0; i < 30; i++)
                {
                    var hw = new Homework
                    {
                        Student = allStudents[rand.Next(allStudents.Count - 1)],
                        Course = allCourses[rand.Next(allCourses.Count - 1)],
                        TimeSent = DateTime.Now,
                    };

                    db.Homeworks.Add(hw);
                }

                db.SaveChanges();
            }
        }
    }
}