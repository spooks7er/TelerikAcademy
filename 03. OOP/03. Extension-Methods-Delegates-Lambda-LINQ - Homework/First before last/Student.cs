using System;

namespace Students
{
    public class Student
    {
        public Student(string fname, string lname)
        {
            this.FName = fname;
            this.LName = lname;
        }
        public Student(string fname, string lname, int age)
            : this(fname, lname)
        {
            this.Age = age;
        }

        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
    }
}
