using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter a whole positive number.");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of bit index.");
            int index = int.Parse(Console.ReadLine());
            int mask = 1;
            mask = mask << index;
            int bit = number & mask;
            bit = bit >> index;
            bool isOne = bit == 1;

            Console.WriteLine("Binary representation of {0} is:", number);
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
            Console.WriteLine("The bit at possition {0} is {1}.", index, bit);
            Console.WriteLine("Is the bit at possition {0} equal to 1: {1}", index, isOne);
            Console.WriteLine();
        }
    }
}