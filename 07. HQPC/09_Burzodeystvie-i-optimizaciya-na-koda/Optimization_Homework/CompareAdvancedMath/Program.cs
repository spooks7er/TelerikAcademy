using System;
using System.Diagnostics;

namespace CompareAdvancedMath
{
    class Program
    {
        private const int Samples = 100;
        private const int Iterations = 10000000;

        static void Main(string[] args)
        {
            Console.WriteLine("Advanced Math Speed Compare\n");
            Console.WriteLine("{0} Samples\n", Samples);
            Console.WriteLine("{0} Iterations\n", Iterations);

            Console.WriteLine("Square Root:\n");
            Console.WriteLine("{0:F6} Milliseconds\n", CompareSquareRoot());

            Console.WriteLine("Natural Logarithm:\n");
            Console.WriteLine("{0:F6} Milliseconds\n", CompareNaturalLogarithm());

            Console.WriteLine("Sinus:\n");
            Console.WriteLine("{0:F6} Milliseconds\n", CompareSinus());

        }

        public static double CompareSquareRoot()
        {
            double n;
            double timeElapsed = 0;

            for (int i = 0; i < Samples; i++)
            {
                Stopwatch sw = Stopwatch.StartNew();

                for (double j = 0; j < Iterations; j++)
                {
                    n = Math.Sqrt(j);
                }
                timeElapsed += sw.Elapsed.TotalMilliseconds;
            }
            return timeElapsed / Samples;
        }

        public static double CompareNaturalLogarithm()
        {
            double n;
            double timeElapsed = 0;

            for (int i = 0; i < Samples; i++)
            {
                Stopwatch sw = Stopwatch.StartNew();

                for (double j = 0; j < Iterations; j++)
                {
                    n = Math.Log(j);
                }
                timeElapsed += sw.Elapsed.TotalMilliseconds;
            }
            return timeElapsed / Samples;
        }

        public static double CompareSinus()
        {
            double n;
            double timeElapsed = 0;

            for (int i = 0; i < Samples; i++)
            {
                Stopwatch sw = Stopwatch.StartNew();

                for (double j = 0; j < Iterations; j++)
                {
                    n = Math.Sin(j);
                }
                timeElapsed += sw.Elapsed.TotalMilliseconds;
            }
            return timeElapsed / Samples;
        }
    }
}
