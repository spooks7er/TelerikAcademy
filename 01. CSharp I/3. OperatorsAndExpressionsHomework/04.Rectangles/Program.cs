using System;

class Program
{
    static void Main()
    {


        Console.WriteLine("Enter width.");
        int w = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter height.");
        int h = int.Parse(Console.ReadLine());
        int p = 2 * (w + h);
        int s = w * h;
        Console.WriteLine("The Perimeter of the rectangle is: {0}", p);
        Console.WriteLine("The Area of the rectangle is: {0}", s);
    }
}