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

            Console.WriteLine("Binary representation of {0} is:", number);
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
            Console.WriteLine("The bit at possition {0} is {1}.", index, bit);

            //The same thing but done with arrays:

            //Console.WriteLine("Enter a whole positive number.");
            //string number = Console.ReadLine();
            //Console.WriteLine("Enter a number of bit index.");
            //int index = int.Parse(Console.ReadLine());

            ////converts base 10 to base 2 with preceding zeros up to 32 bits
            //string bitStr = Convert.ToString(Convert.ToInt32(number, 10), 2).PadLeft(16, '0');

            //char[] bitArr = bitStr.ToCharArray();
            //char[] bitArrRev = new char[bitArr.Length];

            //int len = bitArr.Length;

            ////show bit at given pos, it will be 0 or 1
            //for (int i = 0; i < bitArr.Length; i++)
            //{
            //    bitArrRev[i] = bitArr[bitArr.Length - 1 - i];
            //}
            //char bit = bitArrRev[index];

            //Console.WriteLine("Binary representation of {0} is:", number);
            //Console.WriteLine(bitStr);
            //Console.WriteLine("The bit at possition {0} is {1}.", index, bit);




            Console.WriteLine();
        }
    }
}