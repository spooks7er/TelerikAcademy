using System;

namespace SchoolClasses
{
	public class People : GenericObj
	{
		private string name;
		private int age;
		
		public People(string name, int age)
			:base()
		{
			this.Name = name;
			this.Age = age;
		}
		
		public string Name
		{
			get { return name; }
			private set { name = value; }
		}
		
		public int Age {
			get { return age; }
			private set { age = value; }
		}

	}
}
