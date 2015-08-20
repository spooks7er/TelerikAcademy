namespace StudentsAndCourses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Course
    {
        private readonly ICollection<Student> students;

        public Course()
        {
            this.students = new List<Student>();
        }

        public List<Student> Students
        {
            get { return students.ToArray().ToList(); }
        }

        public Course AddStudent(Student st)
        {
            if (this.students.Count == 30)
            {
                throw new ArgumentOutOfRangeException("This course has reached it's student limit of 30");
            }

            foreach (var student in this.students)
            {
                if (student.ID == st.ID)
                {
                    throw new ArgumentException("This course already contains a student with this ID");
                }
            }

            this.students.Add(st);
            return this; 
        }
    }
}