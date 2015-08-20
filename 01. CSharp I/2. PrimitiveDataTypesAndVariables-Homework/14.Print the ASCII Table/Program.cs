﻿using System;
using System.Text;

//Problem 14.* 
//Print the ASCII Table• Find online more information about ASCII 
//(American Standard Code for Information Interchange) and write a program 
//that prints the entire ASCII table of characters on the console (characters from 0 to 255).

//Note: Some characters have a special purpose and will not be displayed 
//as expected. You may skip them or display them differently.

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;

        for (int count = 0; count <= 255; count++)
        {
            char ascii = (char)count;
            Console.WriteLine("{0} --> {1}", count, ascii);
        }
    }
}