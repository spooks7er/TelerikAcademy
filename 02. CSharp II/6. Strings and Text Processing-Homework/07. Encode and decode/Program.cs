using System;
//Problem 7. Encode/decode
//• Write a program that encodes and decodes a string using given encryption key (cipher).
//• The key consists of a sequence of characters. 
//• The encoding/decoding is done by performing XOR (exclusive or) operation over the 
//first letter of the string with the first of the key, the second – with the second, etc. 
//When the last key character is reached, the next is the first.
class Program
{
    static void Main(string[] args)
    {
        //string text = Console.ReadLine();
        //string key = Console.ReadLine();

        string text = "sausage";
        string key = "banana";

        Console.WriteLine(EncryptDecrypt(text, key));
        Console.WriteLine(EncryptDecrypt(EncryptDecrypt(text, key), key));
    }

    static string EncryptDecrypt(string text, string key)
    {
        string newtext;
        var textArr = text.ToCharArray();
        var keyArr = key.ToCharArray();

        for (int i = 0, j = 0; i < text.Length; i++, j++)
        {
            if (j == key.Length)
            {
                j = 0;
            }
            textArr[i] ^= keyArr[j];
        }
        return newtext = new string(textArr);
    }
}