using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Enter a whole positive number.");
        //string number = Console.ReadLine();
        string number = "1140867093";
        
        int index3 = 3;
        int index4 = 4;
        int index5 = 5;

        int index24 = 24;
        int index25 = 25;
        int index26 = 26;

        char char3;
        char char4;
        char char5;

        char char24;
        char char25;
        char char26;

        // Converts from string containing an int to a string containing the 
        // int's binary representation up to 32 bits
        string numberBits = Convert.ToString(Convert.ToInt32(number, 10), 2).PadLeft(32, '0');
        //
        char[] bitArr = numberBits.ToCharArray();// the binary string is converted to a char array
        
        // we need the same array backwards so we can adress the bit possition more easoly using array[index]
        char[] bitArrRev = new char[bitArr.Length];// we create a char array to store the reverse bits

        // This for loop does the reversing of the char array
        for (int i = 0; i < bitArr.Length; i++)
        {
            bitArrRev[i] = bitArr[bitArr.Length - 1 - i];
        }

        char3 = bitArrRev[index3];
        char4 = bitArrRev[index4];
        char5 = bitArrRev[index5];

        char24 = bitArrRev[index24];
        char25 = bitArrRev[index25];
        char26 = bitArrRev[index26];

        bitArrRev[index3] = char24;
        bitArrRev[index4] = char25;
        bitArrRev[index5] = char26;
        
        bitArrRev[index24] = char3;
        bitArrRev[index25] = char4;
        bitArrRev[index26] = char5;

        // After we've done the exchange we have to reverse the array again to it's normal order
        for (int i = 0; i < bitArr.Length; i++)
        {
            bitArr[i] = bitArrRev[bitArr.Length - 1 - i];
        }

        string newNumber = new string(bitArr);// we create a new string using the now changed char array

        Console.WriteLine("Old number:");
        Console.WriteLine(number);
        Console.WriteLine();
        Console.WriteLine("Old number binary:");
        Console.WriteLine(numberBits);
        Console.WriteLine();
        Console.WriteLine("New number:");
        Console.WriteLine(Convert.ToString(Convert.ToUInt32(newNumber, 2), 10));
        Console.WriteLine();
        Console.WriteLine("New number binary:");
        Console.WriteLine(newNumber);






        //Console.Write("Enter a whole positive number.");
        //int number = int.Parse(Console.ReadLine());
        //int result = number;
        //int mask = 1 << 3;
        //int thirdBit = (result & mask) >> 3;

        //mask = 1 << 24;
        //int twentyFourthBit = (result & mask) >> 24;

        //if (thirdBit == 0)
        //{
        //    //Put 0 in 24th position
        //    mask = ~(1 << 24);
        //    result = (result & mask);
        //}
        //else if (thirdBit == 1)
        //{
        //    //Put 1 in 24th position
        //    mask = 1 << 24;
        //    result = (result | mask);
        //}

        //if (twentyFourthBit == 0)
        //{
        //    //Put 0 in 3rd position
        //    mask = ~(1 << 3);
        //    result = (result & mask);
        //}
        //else if (twentyFourthBit == 1)
        //{
        //    //Put 1 in 3rd position
        //    mask = 1 << 3;
        //    result = (result | mask);
        //}

        //mask = 1 << 4;
        //int FourthBit = (result & mask) >> 4;

        //mask = 1 << 25;
        //int twentyFifthBit = (result & mask) >> 25;

        //if (FourthBit == 0)
        //{
        //    //Put 0 in 25th position
        //    mask = ~(1 << 25);
        //    result = (result & mask);
        //}
        //else if (FourthBit == 1)
        //{
        //    //Put 1 in 25th position
        //    mask = 1 << 25;
        //    result = (result | mask);
        //}

        //if (twentyFifthBit == 0)
        //{
        //    //Put 0 in 4th position
        //    mask = ~(1 << 4);
        //    result = (result & mask);
        //}
        //else if (twentyFourthBit == 1)
        //{
        //    //Put 1 in 4th position
        //    mask = 1 << 4;
        //    result = (result | mask);
        //}

        //mask = 1 << 5;
        //int fifthBit = (result & mask) >> 5;

        //mask = 1 << 26;
        //int twentySixthBit = (result & mask) >> 26;

        //if (fifthBit == 0)
        //{
        //    //Put 0 in 26th position
        //    mask = ~(1 << 26);
        //    result = (result & mask);
        //}
        //else if (fifthBit == 1)
        //{
        //    //Put 1 in 26th position
        //    mask = 1 << 26;
        //    result = (result | mask);
        //}

        //if (twentySixthBit == 0)
        //{
        //    //Put 0 in 5rd position
        //    mask = ~(1 << 5);
        //    result = (result & mask);
        //}
        //else if (twentySixthBit == 1)
        //{
        //    //Put 1 in 3rd position
        //    mask = 1 << 5;
        //    result = (result | mask);
        //}

        //Console.WriteLine("{0}->{1}", number, Convert.ToString(number, 2).PadLeft(32, '0'));
        //Console.WriteLine("{0}->{1}", result, Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}