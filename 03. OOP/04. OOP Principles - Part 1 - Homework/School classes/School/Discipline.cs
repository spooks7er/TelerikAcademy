using System;

namespace SchoolClasses.School
{
	public class Discipline : GenericObj
	{
		private string name;
		private int numOfLectires;
		private int numbOfEx;
		
		public Discipline()
		{
			
		}	
		
		public string Name 
		{
			get { return name; }
			set { name = value; }
		}
		
		public int NumOfLectires
		{
			get { return numOfLectires; }
			set { numOfLectires = value; }
		}
		
		public int NumbOfEx 
		{
			get { return numbOfEx; }
			set { numbOfEx = value; }
		}
	}
}
