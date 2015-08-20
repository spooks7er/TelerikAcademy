using System;
using System.Collections.Generic;

namespace SchoolClasses.School
{
	public class Class : GenericObj
	{
		private List<Teacher> teacherList = new List<Teacher>();
		private List<Student> studList = new List<Student>();
		
		public Class()
			:base()
		{
			
		}
		
		public List<Teacher> TeacherList
		{
			get { return teacherList; }
			set { teacherList = value; }
		}
		
		public List<Student> StudList
		{
			get { return studList; }
			set { studList = value; }
		}

	}
}
