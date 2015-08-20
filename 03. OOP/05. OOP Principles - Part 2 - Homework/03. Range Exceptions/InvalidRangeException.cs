using System;

namespace RangeExceptions
{
    class InvalidRangeException<T> : ArgumentException
    {
        private T min;
        private T max;

        public InvalidRangeException(string msg)
            : base(msg)
        {
        }

        public InvalidRangeException(string msg, Exception inner)
            : base(msg, inner)
        {
        }
        
        public InvalidRangeException(string msg, T min, T max)
            : this(msg)
        {
            this.Min = min;
            this.Max = max;
        }

        public InvalidRangeException(string msg, Exception inner, T min, T max)
            : this(msg, inner)
        {
            this.Min = min;
            this.Max = max;
        }

        public T Min
        {
            get { return this.min; }
            private set { this.min = value; }
        }

        public T Max
        {
            get { return this.max; }
            private set { this.max = value; }
        }
    }
}