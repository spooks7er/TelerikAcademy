using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int a = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 1:
                    case 2:
                    case 3:
                        a *= 10; Console.WriteLine(a);
                        break;
                    case 4:
                    case 5:
                    case 6:
                        a *= 100; Console.WriteLine(a);
                        break;
                    case 7:
                    case 8:
                    case 9:
                        a *= 1000; Console.WriteLine(a);
                        break;
                    default:
                        Console.WriteLine("Invalid Score!");
                        break;
                }
            }
        }
    }
}
