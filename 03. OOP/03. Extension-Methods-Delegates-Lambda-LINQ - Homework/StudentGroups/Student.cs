using System;
using System.Linq;
using System.Collections.Generic;

namespace StudentGroups
{
    public class Student
    {
        private string fName;
        private string lName;
        private int age;
        private string fNumber;
        private string tel;
        private string eMail;
        private List<int> marks = new List<int>();
        private Group groupN;

        public Student(string fname, string lname)
        {
            this.Fname = fname;
            this.Lname = lname;
        }

        public Student(string fname, string lname, int age, string fnumber)
            : this(fname, lname)
        {
            this.Age = age;
            this.Fnumber = fnumber;
        }

        public Student(string fname, string lname, int age, string fnumber, string tel, string email, Group groupN)
            : this(fname, lname, age, fnumber)
        {
            this.Tel = tel;
            this.Email = email;
            this.GroupNumber = groupN;
        }

        public string Fname
        {
            get { return fName; }
            set { fName = value; }
        }

        public string Lname
        {
            get { return lName; }
            set { lName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Fnumber
        {
            get { return fNumber; }
            set { fNumber = value; }
        }
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        public string Email
        {
            get { return eMail; }
            set { eMail = value; }
        }

        public List<int> Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        public Group GroupNumber
        {
            get { return groupN; }
            set { groupN = value; }
        }


        public override string ToString()
        {
            return string.Format("fName: {0}\nlName: {1}\nage: {2}\nfNumber: {3}\ntel: {4}\neMail: {5}\ngroupN: {6} \ndept: {7} \n", fName, lName, age, fNumber, tel, eMail, groupN.GroupNumber, groupN.DepartmentName);
        }

    }
}
