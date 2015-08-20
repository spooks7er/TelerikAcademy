using System;

class Program
{
    static void Main()
    {
        //Console.WriteLine("Enter a whole positive number.");
        //int number = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter number of bit index.");
        //int index = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter 0 or 1.");
        //int bitEx = int.Parse(Console.ReadLine());

        //Console.WriteLine("Binary representation of {0} is:", number);
        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));

        //if (bitEx == 0)
        //{
        //    int mask = ~(1 << index);
        //    number = (number & mask);
        //    Console.WriteLine("The result of modifying bit #{0} to have the value of {1} is the number: {2}", index, bitEx, number);
        //}
        //else
        //{
        //    int mask = 1 << index;
        //    number = (number | mask);
        //    Console.WriteLine("The result of modifying bit #{0} to have the value of {1} is the number: {2}", index, bitEx, number);
        //}
        //Console.WriteLine("Binary representation of {0} after the exchange is:", number);
        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));

        Console.WriteLine("Enter a whole positive number.");
        string number = Console.ReadLine();
        Console.WriteLine("Enter number of bit index.");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter 0 or 1.");
        char bitEx = char.Parse(Console.ReadLine());
        
        string numberBits = Convert.ToString(Convert.ToInt32(number, 10), 2).PadLeft(32, '0');
        
        char[] bitArr = numberBits.ToCharArray();
        char[] bitArrRev = new char[bitArr.Length];

        //show bit at given pos, it will be 0 or 1
        for (int i = 0; i < bitArr.Length; i++)
        {
            bitArrRev[i] = bitArr[bitArr.Length - 1 - i]; //reverse array
        }
        char bit = bitArrRev[index];

        //exchange bit at given pos to 0 or 1
        bit = bitArrRev[index] = bitEx;
        for (int i = 0; i < bitArr.Length; i++)
        {
            bitArr[i] = bitArrRev[bitArr.Length - 1 - i]; //reverse array again
        }
        string newNumber = new string(bitArr);
        Console.WriteLine("Binary representation of {0} is \n{1}",number, numberBits);
        Console.WriteLine("After the exchange {0} becomes {1}.", number, Convert.ToString(Convert.ToUInt32(newNumber, 2), 10));
        Console.WriteLine("Binary representation of the new number is:\n{0}", newNumber);

    }
}