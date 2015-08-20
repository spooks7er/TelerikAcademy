using System;

namespace StudentsAndWorkers
{
	public abstract class Human
	{
		private string fName;
		private string lName;
	
		public Human(string fName, string lName)
		{
			this.FName = fName;
			this.LName = lName;
		}
		
		public string FName 
		{
			get { return fName; }
			private set { fName = value; }
		}
		
		public string LName
		{
			get { return lName; }
			private set { lName = value; }
		}
	}
}
