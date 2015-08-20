/*
Problem 8. Calls
• Create a class  Call  to hold a call performed through a GSM.
• It should contain date, time, dialled phone number and duration (in seconds).
 */
using System;

namespace GSM
{
    public class Call
    {
        private DateTime callStart;
        private DateTime callEnd;
        private string phoneNumber;
        private uint duration;

        public Call(string phoneNumber, DateTime callStart, DateTime callEnd)
        {
            this.phoneNumber = phoneNumber;
            this.callStart = callStart;
            this.callEnd = callEnd;
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
        }

        // It's more practical to store START and END DateTime
        // and get the duration from the difference
        public DateTime CallStart
        {
            get { return this.callStart; }
        }

        public DateTime CallEnd
        {
            get { return this.callEnd; }
        }

        public TimeSpan Duration
        {
            get
            {   //Console.WriteLine("invoke public TimeSpan Duration from Calls class");
                //rounding any milliseconds
                this.callStart = new DateTime((callStart.Ticks / TimeSpan.TicksPerSecond) * TimeSpan.TicksPerSecond);
                this.callEnd = new DateTime((callEnd.Ticks / TimeSpan.TicksPerSecond) * TimeSpan.TicksPerSecond);

                return TimeSpan.FromSeconds((this.CallEnd - this.CallStart).TotalSeconds);
            }
        }

        public uint DurationInSeconds
        {
            get
            {
                return this.duration =
                    (uint)((this.CallEnd - this.CallStart).TotalSeconds);
            }
        }
        //
    }
}
