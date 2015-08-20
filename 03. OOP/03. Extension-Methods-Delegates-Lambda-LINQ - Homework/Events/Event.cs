using System;

namespace Events
{
    class Event : EventArgs
    {
        public static void Cat()
        {
            Console.WriteLine("Cat");
        }

        public static void Dog()
        {
            Console.WriteLine("Dog");
        }

        public static void Mouse()
        {
            Console.WriteLine("Mouse");
        }
    }
}
