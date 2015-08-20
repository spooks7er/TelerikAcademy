using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GSM
{
    public class Dialer
    {
        private static Random _rand = new Random();

        private DateTime callStart = new DateTime();
        private DateTime callEnd = new DateTime();

        public void Dial(string number)
        {
            Console.Write("Processing call.");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(".");

                Thread.Sleep(_rand.Next(200, 500));
            }
            Console.WriteLine("\nCall in Progress:");


            Console.WriteLine("Press SPACE to hang call.");
            callStart = DateTime.Now;
            do
            {
                while (!Console.KeyAvailable)
                {
                    Console.WriteLine(".");

                    Thread.Sleep(1000);
                }
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Spacebar);
            callEnd = DateTime.Now;
            Console.WriteLine("Call Ended.");


            TimeSpan span = new TimeSpan();

            callStart = new DateTime((callStart.Ticks / TimeSpan.TicksPerSecond) * TimeSpan.TicksPerSecond);
            callEnd = new DateTime((callEnd.Ticks / TimeSpan.TicksPerSecond) * TimeSpan.TicksPerSecond);

            span = TimeSpan.FromSeconds((callEnd - callStart).TotalSeconds);
            Console.WriteLine("Call duration - {0}", span);

            Console.WriteLine();
        }

        public DateTime CallStart
        {
            get { return this.callStart; }
        }

        public DateTime CallEnd
        {
            get { return this.callEnd; }
        }

        static void Print(int row, int col, object data)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(col, row);
            Console.Write(data);
        }
    }
}
