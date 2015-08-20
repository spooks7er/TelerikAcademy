using System;

namespace StudentsAndWorkers
{
    public class Student : Human
    {
        private double grade;

        public Student(string fName, string lName)
            : base(fName, lName)
        {

        }

        public Student(string fName, string lName, double grade)
            : this(fName, lName)
        {
            this.Grade = grade;
        }

        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }
    }
}
