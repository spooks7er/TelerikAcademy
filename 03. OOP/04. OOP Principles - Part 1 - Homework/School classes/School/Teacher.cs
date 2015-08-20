using System;
using System.Collections.Generic;

namespace SchoolClasses.School
{
	public class Teacher : People
	{
		private List<Discipline> discList = new List<Discipline>();
		
		public Teacher(string name, int age)
			:base(name, age)
		{
			
		}
		
		public List<Discipline> DiscList
		{
			get { return discList; }
			set { discList = value; }
		}
	}
}
