using System;

class Program
{
    static void Main()
    {
        //while (true)
        //{

        Console.WriteLine("Enter a whole positive number.");
        //string number = Console.ReadLine();
        string number = "4294901775";

        int p = 2;
        int q = 22;
        int k = 10;

        // Converts from string containing an int to a string containing the 
        // int's binary representation up to 32 bits
        string numberBits = Convert.ToString(Convert.ToUInt32(number, 10), 2).PadLeft(32, '0');

        //string numberBits = "abcdefghijklmnopqrstuvwxyz123456";//for debugging

        //
        char[] bitArr = numberBits.ToCharArray();// the binary string is converted to a char array

        // we need the same array backwards so we can adress the bit possition more easoly using array[index]
        char[] bitArrRev = new char[bitArr.Length];// we create a char array to store the reverse bits

        // This for loop does the reversing of the char array
        for (int i = 0; i < bitArr.Length; i++)
        {
            bitArrRev[i] = bitArr[bitArr.Length - 1 - i];
        }


        char[] pArr = new char[k];
        char[] qArr = new char[k];

        //for (int i = 0; i < k; i++)
        //{
        //    pArr[i] = bitArrRev[p + i];
        //    qArr[i] = bitArrRev[q + i];

        //}

        //for (int i = 0; i < k; i++)
        //{
        //    bitArrRev[p + i] = qArr[i];
        //    bitArrRev[q + i] = pArr[i];
        //}

        for (int i = 0; i < k; i++)
        {
            pArr[i] = bitArrRev[p + i];
            qArr[i] = bitArrRev[q + i];
            bitArrRev[p + i] = qArr[i];
            bitArrRev[q + i] = pArr[i];
        }


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






        //Console.WriteLine("Enter a whole number. Must not be greater than {0}", uint.MaxValue);
        //uint num = uint.Parse(Console.ReadLine());
        //Console.WriteLine("Enter 3 digits p, q and k so that p and q are <32 and |p-q|>=k and (p + k <= 32) and (q + k <= 32)");
        //Console.WriteLine("Enter p");
        //int p = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter q");
        //int q = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter k");
        //int k = int.Parse(Console.ReadLine());
        
        //uint num = 4294901775;
        //int p = 2;
        //int q = 22;
        //int k = 10;

        //bool check = (p < 32 && q < 32) && (Math.Abs(p - q) >= k) && (p + k <= 32) && (q + k <= 32);
        ////Console.WriteLine(check);
        //if (check == false)
        //{
        //    Console.WriteLine("The numbers do not satisfy the condition. Please try again.");
        //}
        //else
        //{
        //    int Mask;
        //    int pMask = 0;
        //    uint maskP;
        //    int qMask = 0;
        //    uint maskQ;

        //    int offset = (Math.Abs(p - q));
        //    string mmP;
        //    string mmQ;
        //    for (int i = p; i < p + k; i++)
        //    {
        //        Mask = 1 << i;
        //        pMask = pMask | Mask;
        //        mmP = Convert.ToString(pMask, 2).PadLeft(32, '0');
        //    }
        //    for (int i = q; i < q + k; i++)
        //    {
        //        Mask = 1 << i;
        //        qMask = qMask | Mask;
        //        mmQ = Convert.ToString(qMask, 2).PadLeft(32, '0');
        //    }

        //    maskP = (uint)(pMask & num);
        //    uint newQ = maskP << offset;
        //    maskQ = (uint)(qMask & num);
        //    uint newP = maskQ >> offset;
        //    qMask = ~qMask;
        //    pMask = ~pMask;

        //    int trueMask = pMask & qMask;
        //    uint midNum = (uint)(num & trueMask);
        //    uint result = midNum | newP;
        //    result = result | newQ;
        //    Console.WriteLine("{0}->{1}", num.ToString().PadLeft(10, ' '), Convert.ToString(num, 2).PadLeft(32, '0'));
        //    Console.WriteLine("{0}->{1}", result.ToString().PadLeft(10, ' '), Convert.ToString(result, 2).PadLeft(32, '0'));
        //}
        //}
    }
}