using System;
using System.Runtime.Serialization;

namespace Point3D
{
    [Serializable()]
    struct Point3D: ISerializable
    {
        private static readonly Point3D o = new Point3D(0, 0, 0);

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        static Point3D()
        {
        }

        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D O
        {
            get { return Point3D.o; }
        }

        public override string ToString()
        {
            return string.Format("X: {0}, Y: {1}, Z: {2}", X, Y, Z);
        }

        // stubs for ISerializable
        public Point3D(SerializationInfo info, StreamingContext ctxt)
            : this()
        {
            this.X = (double)info.GetValue("X", typeof(double));
            this.Y = (double)info.GetValue("Y", typeof(double));
            this.Z = (double)info.GetValue("Z", typeof(double));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("X", this.X);
            info.AddValue("Y", this.Y);
            info.AddValue("Z", this.Z);
        }
    }
}
