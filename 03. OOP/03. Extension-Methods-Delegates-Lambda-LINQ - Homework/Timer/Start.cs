using System;

namespace Timer
{
    class Start
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(0.5);

            timer.SomeMethods += TestMethodOne;
            timer.SomeMethods += TestMethodTwo;

            timer.ExecuteMethods();
        }

        public static void TestMethodOne()
        {
            Console.WriteLine("TestMethodOne Executed");
        }

        public static void TestMethodTwo()
        {
            Console.WriteLine("TestMethodTwo Executed");
        }
    }
}
