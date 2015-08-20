using System;

namespace Point3D
{
    static class Distance
    {
        public static double Calculate(Point3D p1, Point3D p2)
        {
            double distance = Math.Sqrt(Math.Pow((p2.X - p1.X), 2) +
                                        Math.Pow((p2.Y - p1.Y), 2) +
                                        Math.Pow((p2.Z - p1.Z), 2));
            return distance;
        }
    }
}
