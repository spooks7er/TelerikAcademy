namespace StudentsAndCourses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class School
    {
        private readonly ICollection<Student> students;

        public School()
        {
            this.students = new List<Student>();
        }

        public List<Student> Students
        {
            get { return students.ToArray().ToList(); }
        }

        public School AddStudent(Student st)
        {
            foreach (var student in this.students)
            {
                if (student.ID == st.ID)
                {
                    throw new ArgumentException("This school already contains a student with this ID");
                }
            }

            this.students.Add(st);
            return this;
        }
    }
}