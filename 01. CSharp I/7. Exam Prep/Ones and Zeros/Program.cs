using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string nBin = Convert.ToString(n, 2).PadLeft(32, '0');
        
        //string first16bits = "";
        //for (int i = 16; i < 32; i++)
        //{
        //    first16bits += nBin[i];
        //} 

        string first16bits = nBin.Substring(16,16);

        for (int i = 0; i < first16bits.Length; i++)
        {
            if (first16bits[i] == '0')
            {
                Console.Write("###");
            }
            else if (first16bits[i] == '1')
            {
                Console.Write(".#.");
            }
            if (i != 15)
            {
                Console.Write(".");
            }
        }
        Console.WriteLine(); 
        for (int i = 0; i < first16bits.Length; i++)
        {
            if (first16bits[i] == '0')
            {
                Console.Write("#.#");
            }
            else if (first16bits[i] == '1')
            {
                Console.Write("##.");
            }
            if (i != 15)
            {
                Console.Write(".");
            }
        }
        Console.WriteLine(); 
        for (int i = 0; i < first16bits.Length; i++)
        {
            if (first16bits[i] == '0')
            {
                Console.Write("#.#");
            }
            else if (first16bits[i] == '1')
            {
                Console.Write(".#.");
            }
            if (i != 15)
            {
                Console.Write(".");
            }
        }
        Console.WriteLine(); 
        for (int i = 0; i < first16bits.Length; i++)
        {
            if (first16bits[i] == '0')
            {
                Console.Write("#.#");
            }
            else if (first16bits[i] == '1')
            {
                Console.Write(".#.");
            }
            if (i != 15)
            {
                Console.Write(".");
            }
        }
        Console.WriteLine(); 
        for (int i = 0; i < first16bits.Length; i++)
        {
            if (first16bits[i] == '0')
            {
                Console.Write("###");
            }
            else if (first16bits[i] == '1')
            {
                Console.Write("###");
            }
            if (i!=15)
            {
                Console.Write(".");
            }
        }
        Console.WriteLine();
    }
}