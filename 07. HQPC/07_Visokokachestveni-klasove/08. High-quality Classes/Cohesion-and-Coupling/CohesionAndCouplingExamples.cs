using System;

namespace CohesionAndCoupling
{
    class CohesionAndCouplingExamples
    {
        static void Main()
        {
            Console.WriteLine(FileName.GetFileExtension("example"));
            Console.WriteLine(FileName.GetFileExtension("example.pdf"));
            Console.WriteLine(FileName.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileName.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileName.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileName.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                Geometry.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                Geometry.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Cuboid box = new Cuboid(3, 4, 5);

            Console.WriteLine("Volume = {0:f2}", Geometry.CalcVolume(box));
            Console.WriteLine("Diagonal XYZ = {0:f2}", Geometry.CalcDiagonal3D(box.Width, box.Height, box.Depth));
            Console.WriteLine("Diagonal XY = {0:f2}", Geometry.CalcDiagonal2D(box.Width, box.Height));
            Console.WriteLine("Diagonal XZ = {0:f2}", Geometry.CalcDiagonal2D(box.Height, box.Depth));
            Console.WriteLine("Diagonal YZ = {0:f2}", Geometry.CalcDiagonal2D(box.Height, box.Depth));
        }
    }
}