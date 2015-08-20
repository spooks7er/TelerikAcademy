namespace CohesionAndCoupling
{
    using System;

    public static class Geometry
    {
        public static double CalcVolume(Cuboid rect)
        {
            double volume = rect.Width * rect.Height * rect.Depth;
            return volume;
        }

        public static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        public static double CalcDiagonal2D(double x, double y)
        {
            double distance = CalcDistance2D(0, 0, x, y);
            return distance;
        }

        public static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
            return distance;
        }
        
        public static double CalcDiagonal3D(double x, double y, double z)
        {
            double distance = CalcDistance3D(0, 0, 0, x, y, z);
            return distance;
        }
    }
}