using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter a whole positive number.");
            int number = int.Parse(Console.ReadLine());
            int index = 3;
            int mask = 1;
            mask = mask << index;
            int bit = number & mask;
            bit = bit >> index;

            Console.WriteLine("Binary representation of {0} is:", number);
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
            Console.WriteLine("The bit at possition {0} is {1}.", index, bit);
            Console.WriteLine();
        }
    }
}