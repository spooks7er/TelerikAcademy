namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LocalCourse : Course
    {
        private string lab;

        public LocalCourse(string name)
            : base(name, null, null)
        {
            this.Lab = null;
        }

        public LocalCourse(string name, string teacherName)
            : base(name, teacherName, null)
        {
            this.Lab = null;
        }

        public LocalCourse(string name, string teacherName, IList<string> students)
            : base(name, teacherName, students)
        {
            this.Lab = null;
        }

        public LocalCourse(string name, string teacherName, IList<string> students, string lab)
            : base(name, teacherName, students)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }
            set
            {
                this.lab = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            if (this.Lab != null)
            {
                result.Append(";\n Lab = ");
                result.Append(this.Lab);
            }

            result.Append("\n}\n");
            return base.ToString() + result.ToString();
        }
    }
}