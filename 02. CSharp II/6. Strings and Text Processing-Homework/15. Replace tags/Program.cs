using System;
//Problem 15. Replace tags
//• Write a program that replaces in a HTML document given as string 
//all the tags  <a href="…">…</a>  with corresponding tags  [URL=…]…[/URL] .

//<p>Please visit <a href="http://academy.telerik.
//com">our site</a> to choose a training course. Also
//visit <a href="www.devbg.org">our forum</a> to discuss
//the courses.</p> 

//<p>Please visit [URL=http://academy.telerik.
//com]our site[/URL] to choose a training course. Also
//visit [URL=www.devbg.org]our forum[/URL] to discuss
//the courses.</p> 

class Program
{
    static void Main(string[] args)
    {
        string input = @"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";

        string openTag1 = "<a href=\"";
        string openTagEnd1 = "\">";
        string closeTag1 = "</a>";


        string openTag2 = "[URL=";
        string openTagEnd2 = "]";
        string closeTag2 = "[/URL]";

        input = input.Replace(openTag1, openTag2).
                      Replace(openTagEnd1, openTagEnd2).
                      Replace(closeTag1, closeTag2);

        Console.WriteLine(input);
    }
}