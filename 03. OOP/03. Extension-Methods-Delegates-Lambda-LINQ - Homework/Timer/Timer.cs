using System;
using System.Threading;

namespace Timer
{
    public class Timer
    {
        private delegate void TimerDel();

        private double timeInterval;

        public Timer(double seconds)
        {
            this.TimeInterval = seconds;
        }

        public TimerDel SomeMethods { get; set; }

        public double TimeInterval
        {
            get { return this.timeInterval; }
            private set
            {
                this.timeInterval = value;
            }
        }

        public void ExecuteMethods()
        {
            while (true)
            {
                this.SomeMethods();
                Thread.Sleep((int)(this.timeInterval * 1000));
            }
        }
    }
}
