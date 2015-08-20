using System;
using System.Diagnostics;

namespace CompareSimpleMaths
{
    class Program
    {
        private const int Samples = 100;
        private const int Iterations = 10000000;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Math Speed Compare\n");
            Console.WriteLine("{0} Samples\n", Samples);
            Console.WriteLine("{0} Iterations\n", Iterations);

            Console.WriteLine("Add:\n");
            Console.WriteLine("{0} Milliseconds\n", CompareAdd());

            Console.WriteLine("Substract:\n");
            Console.WriteLine("{0:F6} Milliseconds\n", CompareSubstract());

            Console.WriteLine("Increment:\n");
            Console.WriteLine("{0:F6} Milliseconds\n", CompareIncrement());

            Console.WriteLine("Multiply:\n");
            Console.WriteLine("{0:F6} Milliseconds\n", CompareMultiply());

            Console.WriteLine("Divide:\n");
            Console.WriteLine("{0:F6} Milliseconds\n", CompareDivide());
        }

        public static double CompareAdd()
        {
            int n = 1;
            double timeElapsed = 0;

            for (int i = 0; i < Samples; i++)
            {
                Stopwatch sw = Stopwatch.StartNew();

                for (int j = 0; j < Iterations; j++)
                {
                    n += j;
                }
                timeElapsed += sw.Elapsed.TotalMilliseconds;
            }
            return timeElapsed / Samples;
        }

        private static double CompareSubstract()
        {
            int n = 1;
            double timeElapsed = 0;

            for (int i = 0; i < Samples; i++)
            {
                Stopwatch sw = Stopwatch.StartNew();

                for (int j = 0; j < Iterations; j++)
                {
                    n -= j;
                }
                timeElapsed += sw.Elapsed.TotalMilliseconds;
            }
            return timeElapsed / Samples;
        }

        private static double CompareIncrement()
        {
            int n = 1;
            double timeElapsed = 0;

            for (int i = 0; i < Samples; i++)
            {
                Stopwatch sw = Stopwatch.StartNew();

                for (int j = 0; j < Iterations; j++)
                {
                    n++;
                }
                timeElapsed += sw.Elapsed.TotalMilliseconds;
            }
            return timeElapsed / Samples;
        }

        private static double CompareMultiply()
        {
            int n = 1;
            double timeElapsed = 0;

            for (int i = 0; i < Samples; i++)
            {
                Stopwatch sw = Stopwatch.StartNew();

                for (int j = 0; j < Iterations; j++)
                {
                    n*=j;
                }
                timeElapsed += sw.Elapsed.TotalMilliseconds;
            }
            return timeElapsed / Samples;
        }

        private static double CompareDivide()
        {
            int n = 1;
            double timeElapsed = 0;

            for (int i = 0; i < Samples; i++)
            {
                Stopwatch sw = Stopwatch.StartNew();

                for (int j = 1; j <= Iterations; j++)
                {
                    n /= j;
                }
                timeElapsed += sw.Elapsed.TotalMilliseconds;
            }
            return timeElapsed / Samples;
        }
    }
}