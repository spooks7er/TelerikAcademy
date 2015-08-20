using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class TRES4_Numbers
{
    static void Main(string[] args)
    {
        //Dictionary<ulong, string> numbersDict = new Dictionary<ulong, string>()
        //{
        //    {0, "LON+"},
        //    {1, "VK-"},
        //    {2, "*ACAD"},
        //    {3, "^MIM"},
        //    {4, "ERIK|"},
        //    {5, "SEY&"},
        //    {6, "EMY>>"},
        //    {7, "/TEL"},
        //    {8, "<<DON"},
        //};
        string[] numbersArr = { "LON+",
                                "VK-",
                                "*ACAD",
                                "^MIM",
                                "ERIK|",
                                "SEY&",
                                "EMY>>",
                                "/TEL",
                                "<<DON"};
        ulong number = ulong.Parse(Console.ReadLine());
        ulong digit = 0;
        StringBuilder converded = new StringBuilder();
        do
        {
            digit = number % 9;
            converded.Insert(0, numbersArr[digit]);
            number /= 9;
        } 
        while (number > 0);

        Console.WriteLine(converded);
    }
}