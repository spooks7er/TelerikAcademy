using System;
using System.Threading;
using System.Threading.Tasks;

namespace testing_some_stuff
{
	class Program
	{
		private static Random _rand = new Random();

		public static void Main(string[] args)
		{
			TestClass test = new TestClass();
			
			test.CallStart = DateTime.Now;
			for (int i = 0; i < 1; i++)
			{
				Console.WriteLine(".");
				
				//Thread.Sleep(_rand.Next(500,800));
				Thread.Sleep(1566);
			}
			test.CallEnd = DateTime.Now;
			
			Console.WriteLine(test.DurationMs);
			Console.WriteLine(test.Duration);

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
	
	class TestClass
	{
		private DateTime callStart;
		private DateTime callEnd;
		
		public DateTime CallStart
		{
			get {return this.callStart;}
			set {this.callStart=value;}
		}
		
		public DateTime CallEnd
		{
			get {return this.callEnd;}
			set {this.callEnd=value;}
		}

		public TimeSpan Duration
		{
			get
			{
				this.CallStart = new DateTime((callStart.Ticks / TimeSpan.TicksPerSecond) * TimeSpan.TicksPerSecond);
				this.CallEnd = new DateTime((callEnd.Ticks / TimeSpan.TicksPerSecond) * TimeSpan.TicksPerSecond);

				return TimeSpan.FromSeconds((this.CallEnd - this.CallStart).TotalSeconds);
			}
		}
		public TimeSpan DurationMs
		{
			get
			{
				return TimeSpan.FromSeconds((this.CallEnd - this.CallStart).TotalSeconds);
			}
		}
	}
}