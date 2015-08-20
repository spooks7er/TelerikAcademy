using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Enter a whole number.");
            int a = int.Parse(Console.ReadLine());
            if ((a % 5 == 0) && (a % 7 == 0))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}