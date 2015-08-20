namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OffsiteCourse : Course
    {
        private string town;

        public OffsiteCourse(string name)
            : base(name, null, null)
        {
            this.Town = null;
        }

        public OffsiteCourse(string name, string teacherName)
            : base(name, teacherName, null)
        {
            this.Town = null;
        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName, students)
        {
            this.Town = null;
        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students, string town)
            : base(courseName, teacherName, students)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                this.town = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            if (this.Town != null)
            {
                result.Append(";\n Town = ");
                result.Append(this.Town);
            }

            result.Append("\n}\n");
            return base.ToString() + result.ToString();
        }
    }
}