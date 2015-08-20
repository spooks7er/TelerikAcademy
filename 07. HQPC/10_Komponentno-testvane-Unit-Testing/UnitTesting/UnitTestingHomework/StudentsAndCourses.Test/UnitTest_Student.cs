using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudentsAndCourses.Test
{
    [TestClass]
    public class UnitTest_Student
    {   
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Student_Name_ThrowIfEmpty()
        {
            var st = new Student(Constants.INVALID_ST_NAME, Constants.VALID_ST_ID);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_Student_ID_ThrowIfSmallerThan10000()
        {
            var st = new Student(Constants.VALID_ST_NAME, Constants.INVALID_ST_ID_SMALLER);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_Student_ID_ThrowIfBiggerThan99999()
        {
            var st = new Student(Constants.VALID_ST_NAME, Constants.INVALID_ST_ID_BIGGER);
        }
    }
}
