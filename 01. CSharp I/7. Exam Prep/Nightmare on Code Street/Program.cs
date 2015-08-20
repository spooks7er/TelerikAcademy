using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nightmare_on_Code_Street
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int count = 0;
            int sum = 0;

            char[] charr = input.ToCharArray();
            char[] numbers = new char[charr.Length];
            for (int i = 0; i < charr.Length; i++)
            {
                if (Char.IsDigit(charr[i]) && i % 2 != 0)
                {
                    numbers[count] = charr[i];
                    sum = sum + numbers[count]-'0';
                    ++count;
                }
            }
            Console.WriteLine("{0} {1}", count, sum);
        }
    }
}
