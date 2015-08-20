using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter a number.");
            int a = Convert.ToInt32(Console.ReadLine());

            //int a = 165764;
            int third = (a / 100) % 10;
            if (third == 7)
            {
                Console.WriteLine("Success!!!");
                Console.WriteLine("The third digit from right-to-left is ({0})", third);
            }
            else
            {
                Console.WriteLine("Fail!!!");
                Console.WriteLine("The third digit from right-to-left is not (7), it's ({0})", third);
            }
        }
    }
}
