using System;
using System.Globalization;
using System.Threading;
//• Write methods that calculate the surface of a triangle by given: 
//◦ Side and an altitude to it;
//◦ Three sides;
//◦ Two sides and an angle between them;
//• Use  System.Math .
class Program
{
    static void Main()
    {        
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Calculate surface of a triangle by:");
        Console.WriteLine("1. Side and an altitude to it.");
        Console.WriteLine("2. Three sides.");
        Console.WriteLine("3. Two sides and an angle between them.");
        Console.WriteLine("Choose 1, 2 or 3)");
        string select = Console.ReadLine();
        Console.WriteLine();
        switch (select)
        {
            case "1": Console.WriteLine("1. Side and an altitude to it.");
                Console.WriteLine();
                SideAndAlt(); break;
            case "2": Console.WriteLine("2. Three sides.");
                Console.WriteLine();
                ThreeSides(); break;
            case "3": Console.WriteLine("3. Two sides and an angle between them.");
                Console.WriteLine();
                TwoSidesAndAngle(); break;
            default: Console.WriteLine("Enter a valid number 1, 2 or 3.");
                Console.WriteLine();
                break;
        }
    }

    private static void SideAndAlt()
    {
        Console.WriteLine("Enter the side length:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the altitude to that side:");
        double h = double.Parse(Console.ReadLine());

        double s = (0.5 * a) * h;

        Console.WriteLine("The surface of the triangle is {0:F2}.", s);
    }
    
    private static void ThreeSides()
    {
        Console.WriteLine("Enter the first side length:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second side length:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Thisd side length:");
        double c = double.Parse(Console.ReadLine());

        double semiP = (a + b + c) / 2;

        double s = Math.Sqrt(semiP*(semiP - a)*(semiP - b)*(semiP - c));
        Console.WriteLine("The surface of the triangle is {0:F2}.", s);
    }

    private static void TwoSidesAndAngle()
    {
        Console.WriteLine("Enter the first side length:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second side length:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the angle between the two sides:");
        double C = double.Parse(Console.ReadLine());
        
        double Cradian = Math.PI * C / 180;

        double s = (0.5 * a * b) * (Math.Sin(Cradian));

        Console.WriteLine("The surface of the triangle is {0:F2}.", s);
    }
}