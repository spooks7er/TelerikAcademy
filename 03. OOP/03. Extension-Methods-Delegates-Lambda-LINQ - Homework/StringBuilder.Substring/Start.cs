using System;
using System.Text;

namespace Ex1
{
    class Start
    {
        public static void Main(string[] args)
        {
            StringBuilder testMe = new StringBuilder();

            testMe.Append("string1");
            testMe.Append("string2");
            testMe.Append("string3");

            var result = testMe.Substring(0, 7);
            var result2 = testMe.Substring(14);

            Console.WriteLine(result);
            Console.WriteLine(result2);
        }
    }
}