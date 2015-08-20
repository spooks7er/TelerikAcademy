using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___x_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            //int n = 6;
            //int d = 5;

            int h = 2 * n + 1;
            int w = h;

            int f = d * 2 + 4;

            int g = (n - (d / 2) - 1) * 2 - 1;

            int realW = f + g;
            int innerlen = ((h - d - 2) / 2) * 2 - 1;
            int trimmer = 0;
            string rowww = "";
            int start = (realW - w) / 2;

            for (int i = 0; i < innerlen / 2 + 1; i++)
            {
                rowww = new string('.', i) + "\\" + new string('#', d) + "\\" + new string('.', innerlen - trimmer) + "/" + new string('#', d) + "/" + new string('.', i);
                Console.WriteLine(rowww.Substring(start, w));
                trimmer = trimmer + 2;
            }

            rowww = new string('.', (realW - (d * 2 + 3)) / 2) + "\\" + new string('#', d) + "X" + new string('#', d) + "/" + new string('.', w - (d * 2 + 3));
            Console.WriteLine(rowww.Substring(start, w));
            trimmer = 1;
            for (int i = 0; i < d / 2; i++)
            {
                rowww = new string('.', (realW - ((d * 2) - i)) / 2) + "\\" + new string('#', d * 2 - trimmer-i) + "/" + new string('.', (realW - ((d * 2) - i)) / 2);
                Console.WriteLine(rowww.Substring(start, w));
                //Console.WriteLine(rowww);
                trimmer++;
            }
            rowww = new string('.', (realW - d - 2) / 4) + "X" + new string('#', d) + "X" + new string('.', (realW - d - 2) / 4);
            Console.WriteLine(rowww);
            trimmer = 3;
            int ii = 1;
            for (int i = 0; i < d / 2; i++)
            {
                rowww = new string('.', (realW - ((d * 2) - ii)) / 2) + "/" + new string('#', d * 2 - trimmer + i) + "\\" + new string('.', (realW - ((d * 2) - ii)) / 2);
                Console.WriteLine(rowww.Substring(start, w));
                //Console.WriteLine(rowww);
                trimmer--;
                ii--;
            }
            rowww = new string('.', (realW - (d * 2 + 3)) / 2) + "/" + new string('#', d) + "X" + new string('#', d) + "\\" + new string('.', w - (d * 2 + 3));
            Console.WriteLine(rowww.Substring(start, w));
            ii = 3;
            trimmer = 2;
            for (int i = 0; i < innerlen / 2 + 1; i++)
            {
                rowww = new string('.', ii) + "/" + new string('#', d) + "/" + new string('.', innerlen - trimmer-2) + "\\" + new string('#', d) +"\\" +new string('.', ii);
                //Console.WriteLine(rowww);
                Console.WriteLine(rowww.Substring(start+1, w));
                trimmer=trimmer-2;
                ii--;
            }

        }
    }
}
