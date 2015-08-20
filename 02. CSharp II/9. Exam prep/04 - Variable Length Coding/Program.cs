using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        //string input = "251 253 214 255 223 187 254 254 183 175 254 240";

        //string[] codeValuePair = { " 2", "S5", "a6", "e1", "l7", "m3", "o8", "p9", "s10", "t4", "x11" };


        string input = Console.ReadLine();

        int codeTableLen = int.Parse(Console.ReadLine());

        string[] codeValuePair = new string[codeTableLen];
        for (int i = 0; i < codeValuePair.Length; i++)
        {
            codeValuePair[i] = Console.ReadLine();
        }

        Dictionary<int, char> codeS = new Dictionary<int, char>();
        for (int i = 0; i < codeValuePair.Length; i++)
        {
            codeS.Add(int.Parse(codeValuePair[i].Substring(1)), char.Parse(codeValuePair[i].Substring(0, 1)));
        }
        
        //char[] codeLetters = new char[codeValuePair.Length + 1];
        //for (int i = 0; i < codeLetters.Length-1; i++)
        //{
        //    codeLetters[int.Parse(codeValuePair[i].Substring(1))] = codeValuePair[i][0];
        //}

        string[] binary = input.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
        byte[] bytes = new byte[binary.Length];

        for (int i = 0; i < binary.Length; i++)
        {
            bytes[i] = byte.Parse(binary[i]);
        }

        StringBuilder onesZeros = new StringBuilder();

        foreach (var item in bytes)
        {
            onesZeros.Append(Convert.ToString(item, 2).PadLeft(8, '0'));
        }

        //Console.WriteLine(onesZeros.ToString());

        string[] onesArray = onesZeros.ToString()
            .Split(new char[] { '0' }, StringSplitOptions.RemoveEmptyEntries);

        //for (int i = 0; i < onesArray.Length; i++)
        //{
        //    Console.WriteLine(onesArray[i]);
        //}

        for (int i = 0; i < onesArray.Length; i++)
        {
            Console.Write(codeS[onesArray[i].Length]);
        }        
        //for (int i = 0; i < onesArray.Length; i++)
        //{
        //    Console.Write(codeLetters[onesArray[i].Length]);
        //}

        Console.WriteLine();
    }
}