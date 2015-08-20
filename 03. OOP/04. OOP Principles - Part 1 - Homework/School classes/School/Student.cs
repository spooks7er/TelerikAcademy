using System;

namespace SchoolClasses.School
{
	public class Student : People
	{
		string uniqueClassNumber;
		
		public Student(string name, int age, string ucn)
			:base(name, age)
		{
			this.UniqueClassNumber = ucn;
		}		
		
		public string UniqueClassNumber
		{
			get { return uniqueClassNumber; }
			private set { uniqueClassNumber = value; }
		}

	}
}
