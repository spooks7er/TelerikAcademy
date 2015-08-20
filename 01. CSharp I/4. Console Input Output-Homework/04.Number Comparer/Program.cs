using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine(Math.Max(a,b));


        //bool equal = a == b;
        //bool diff = a > b;

        //switch (equal)
        //{
        //    case true:
        //        Console.WriteLine("The two numbers are equal", a);
        //        break;
        //    case false:
        //        switch (diff)
        //        {
        //            case true:
        //                Console.WriteLine("The first number {0} is the greater of the two.", a);
        //                break;
        //            case false:
        //                Console.WriteLine("The second number {0} is the greater of the two.", b);
        //                break;
        //            default:
        //                break;
        //        }
        //        break;
        //    default:
        //        break;
        //}
    }
}