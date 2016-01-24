namespace AcademySystem.ConsoleClient
{
    using System;
    using System.Linq;
    using AcademySystem.Data;
    using AcademySystem.Models;

    public class Startup
    {
        public static void Main()
        {
            //connect to local database with management studio (LocalDB)\MSSQLLocalDB

            var fillData = new SampleDataFiller();

            //// UNCOMENT these methods and run the app.
            //// They must always be executed in this order

            //fillData.FillSampleStudents();

            //fillData.FillSampleCoursesWithStudents();

            //fillData.FillSampleHomeworks();
        }
    }
}
