namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course
    {
        private string name;
        private string teacherName;
        private IList<string> students;
        
        public Course(string name, string teacherName, IList<string> students)
        {
            this.Name = name;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < 2 || value.Length > 50)
                {
                    throw new ArgumentException("Course Name must be between 2 amd 50 characters");
                }
                this.name = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }
            set
            {
                if (value != null)
                {
                    if (value.Length < 2 || value.Length > 30)
                    {
                        throw new ArgumentException("Teacher Name must be between 2 amd 30 characters");
                    }
                }

                this.teacherName = value;
            }
        }

        public IList<string> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }

        private string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("LocalCourse {\n Name = ");
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append(";\n Teacher = ");
                result.Append(this.TeacherName);
            }
            result.Append(";\n Students = ");
            result.Append(this.GetStudentsAsString());
            return result.ToString();
        }
    }
}