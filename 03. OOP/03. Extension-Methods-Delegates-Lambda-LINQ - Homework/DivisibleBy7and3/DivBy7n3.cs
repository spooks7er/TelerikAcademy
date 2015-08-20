using System;
using System.Linq;

namespace DivisibleBy7and3
{
    class DivBy7n3
    {
        public static void Main(string[] args)
        {
            var someArrayOfInts = new int[1000];
            for (int i = 1; i <= 1000; i++)// filling
            {                              // the array
                someArrayOfInts[i - 1] = i;
            }

            //var divBy = someArrayOfInts
            //    .Where(n => n % 3 == 0 && n % 7 == 0);

            var divBy =
                from n in someArrayOfInts
                where n % 3 == 0 && n % 7 == 0
                select n;

            foreach (var item in divBy)
            {
                Console.WriteLine(item);
            }
        }
    }
}