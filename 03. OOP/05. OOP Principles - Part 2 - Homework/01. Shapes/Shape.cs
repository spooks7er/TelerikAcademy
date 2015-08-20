using System;

namespace Shapes
{
    public abstract class Shape
    {
        private double width;
        private double height;


        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get { return width; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Width must be non-negative");
                }

                width = value;
            }
        }

        public double Height
        {
            get { return height; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Height must be non-negative");
                }
                height = value;
            }
        }

        public abstract double CalculateSurface();

        //public virtual double CalculateSurface()
        //{
        //    return 0;
        //}
    }
}
