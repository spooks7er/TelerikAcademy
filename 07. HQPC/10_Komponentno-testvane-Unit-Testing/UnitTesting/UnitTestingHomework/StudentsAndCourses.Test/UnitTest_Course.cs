using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudentsAndCourses.Test
{
    [TestClass]
    public class UnitTest_Course
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_AddStudent_MustThrowIfCountBiggetThan30()
        {   
            var crs = new Course();
            for (int i = 0; i < 31; i++)
            {
                var st = new Student(Constants.VALID_ST_NAME+i, Constants.VALID_ST_ID+i);
                st.JoinCourse(crs);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_AddStudent_MustThrowIfCountAlreadyContainsStudentWithThisID()
        {
            var crs = new Course();
            var st = new Student(Constants.VALID_ST_NAME, Constants.VALID_ST_ID);

            for (int i = 0; i < 2; i++)
            {
                st.JoinCourse(crs);
            }
        }
    }
}
