namespace StudentsAndCourses
{
    using System;

    public class Student
    {
        private string name;
        private int id;

        public Student(string name, int schoolID)
        {
            this.Name = name;
            this.ID = schoolID;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Name must not be empty");
                }
                name = value;
            }
        }

        public int ID
        {
            get { return id; }
            private set
            {
                if (value < 10000 || value > 99999)
                {
                    throw new ArgumentOutOfRangeException("SchoolID must be between 10000 and 99999");
                }
                id = value;
            }
        }

        public Student JoinCourse(Course crs)
        {
            crs.AddStudent(this);
            return this;
        }
    }
}