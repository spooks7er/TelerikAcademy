using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _09.Play_with_Int__Double_and_String
{
    class Program
    {
        static void Main(string[] args)
        {            
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            while (true)
            {
                Console.WriteLine("Please choose a type:");
                Console.WriteLine(@"1 --> int  
2 --> double  
3 --> string");
                int type = int.Parse(Console.ReadLine());
                switch (type)
                {
                    case 1:
                        Console.WriteLine("Please enter a int:");
                        int integ = int.Parse(Console.ReadLine());
                        integ += 1;
                        Console.WriteLine(integ);
                        break;
                    case 2:
                        Console.WriteLine("Please enter a double:");
                        double dub = double.Parse(Console.ReadLine());
                        dub += 1;
                        Console.WriteLine(dub);
                        break;
                    case 3:
                        Console.WriteLine("Please enter a string:");
                        string str = Console.ReadLine();
                        str += "*";
                        Console.WriteLine(str);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}