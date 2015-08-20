namespace CohesionAndCoupling
{
    public class Cuboid
    {
        private double width;
        private double height;
        private double depth;

        public Cuboid(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }
            set
            {
                this.depth = value;
            }
        }
    }
}