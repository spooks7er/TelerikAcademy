using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudentsAndCourses.Test
{
    [TestClass]
    public class UnitTest_School
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_AddStudent_MustThrowIfCountAlreadyContainsStudentWithThisID()
        {
            var sch = new School();
            var st = new Student(Constants.VALID_ST_NAME, Constants.VALID_ST_ID);

            for (int i = 0; i < 2; i++)
            {
                sch.AddStudent(st);
            }
        }
    }
}
