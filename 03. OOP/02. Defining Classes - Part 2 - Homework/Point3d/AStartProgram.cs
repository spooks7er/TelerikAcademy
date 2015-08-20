using System;

namespace Point3D
{
    class AStartProgram
    {
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D(12, 17, 16);
            Point3D p2 = new Point3D(322, 32, 54);
            Point3D p3 = new Point3D(10, 10, 10);

            double d = Distance.Calculate(Point3D.O, p3);
            Console.WriteLine("Point p3 in the 3d space has coordinates {0}\n", p3);
            Console.WriteLine("The distance between point O and point p3 is {0}\n", d);

            Path path = new Path();

            path.PathList.Add(p1);
            path.PathList.Add(p2);
            path.PathList.Add(p3);

            Console.WriteLine("This is the path before the serialization in to a file\n");

            foreach (Point3D point in path.PathList)
            {
                Console.WriteLine(point);
            }

            Console.WriteLine("\nThis is the path after being read from the file\n");

            PathStorage pathStorage = new PathStorage();

            // serializing and storing in file
            pathStorage.SerializeObject(@"..\..\StorageFile.txt", path);

            // reading from file and deserializing
            var deserialized = pathStorage.DeSerializeObject(@"..\..\StorageFile.txt");
            path = deserialized;

            foreach (Point3D point in path.PathList)
            {
                Console.WriteLine(point);
            }
        }
    }
}
