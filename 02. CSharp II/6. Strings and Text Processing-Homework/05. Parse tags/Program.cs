using System;
//Problem 5. Parse tags
//• You are given a text. Write a program that changes the text in 
//all regions surrounded by the tags  <upcase>  and  </upcase>  to upper-case.
//• The tags cannot be nested.

//Example: We are living in a  <upcase> yellow submarine </upcase> . 
//We don't have  <upcase> anything </upcase>  else.

//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
namespace _05.Parse_tags
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"We are living in a <upcase> yellow submarine </upcase>. We don't have <upcase> anything </upcase> else.";
            var chararr = text.ToCharArray();
            string openTag = "<upcase>";
            string closeTag = "</upcase>";

            string current = string.Empty;

            int openIindex = 0;
            int closeIndex = 0;
            while (true)
            {
                int openFound = text.IndexOf(openTag, openIindex);
                if (openFound < 0)
                {
                    break;
                }
                openIindex = openFound + 1;
                int closeFound = text.IndexOf(closeTag, closeIndex);
                if (closeFound < 0)
                {
                    break;
                }
                closeIndex = closeFound + 1;

                text = text.Replace(text.Substring(openFound + openTag.Length, closeFound - (openFound + openTag.Length)), text.Substring(openFound + openTag.Length, closeFound - (openFound + openTag.Length)).ToUpper().Trim());
            }
            text = text.Replace(openTag, "").Replace(closeTag, "");

            //Console.Write("Enter text: ");
            //string text = Console.ReadLine();
            //Console.WriteLine(Regex.Replace(text, "<upcase>(.*?)</upcase>", word => word.Groups[1].Value.ToUpper()));


            Console.WriteLine(text);
        }
    }
}
