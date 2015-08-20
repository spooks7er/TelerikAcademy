using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//Problem 25. Extract text from HTML
//• Write a program that extracts from given HTML file its title (if available), 
//and its body text without the HTML tags.

//Example input:
//<html>
//  <head><title>News</title></head>
//  <body><p><a href="http://academy.telerik.com">Telerik
//    Academy</a>aims to provide free real-world practical
//    training for young people who want to turn into
//    skilful .NET software engineers.</p></body>
//</html>

//Output: 

//Title: News

//Text: Telerik Academy aims to provide free real-world practical training for
//young people who want to turn into skilful .NET software engineers.
class Program
{
    static void Main(string[] args)
    {
        //char tagBrL = '<';
        //char tagBrR = '>';


        string text = @"<html>
<head><title>News</title></head>
<body><p><a href=""http://academy.telerik.com"">Telerik
Academy</a>aims to provide free real-world practical
training for young people who want to turn into
skilful .NET software engineers.</p></body></html>";

        int sTitleTagPos = text.IndexOf("<title>");
        int eTitleTagPos = text.IndexOf("</title>");

        int titleTagContLen = eTitleTagPos - (sTitleTagPos+7);

        string title = text.Substring(sTitleTagPos + 7, titleTagContLen);
        string noHTML = Regex.Replace(text.Substring(eTitleTagPos), @"<[^>]+>|&nbsp;",  " ").Trim();
        string noHTMLNormalised = Regex.Replace(noHTML, @"\s{2,}", " ");
        Console.WriteLine("Title: {0}",title);
        Console.WriteLine("Text: {0}", noHTMLNormalised);
        


        //List<char> textList = text.Trim().ToList();
        //bool inTag = false;
        //int tagStart = 0;
        //int tagLen = 0;
        //int count = 0;
        //foreach (var item in textList)
        //{
        //    if (item == tagBrL)
        //    {
        //        inTag = true;
        //        tagStart = count;
        //    }
        //    if (item == tagBrR)
        //    {
        //        textList.Remove(item);

        //        inTag = false;
        //    }
        //    if (inTag)
        //    {
        //        textList.Remove(item);
        //        tagLen++;
        //    }
        //    count++;
        //}

        //foreach (var item in textList)
        //{
        //    Console.Write(item);
        //}
    }
}