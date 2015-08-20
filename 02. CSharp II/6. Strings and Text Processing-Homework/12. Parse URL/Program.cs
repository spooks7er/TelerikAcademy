using System;
using System.Linq;
//Problem 12. Parse URL
//• Write a program that parses an URL address given in the format:
//[protocol]://[server]/[resource]  
//and extracts from it the  [protocol] ,  [server]  and  [resource]  elements.

class Program
{
    static void Main(string[] args)
    {
        Console.Write("[url] = ");
        
        string url = Console.ReadLine();
        
        //string url = "http://telerikacademy.com/Courses/Courses/Details/212";
        //string url = "https://www.youtube.com/results?search_query=anders+osborne+black+tar";
        
        string protocol = url.Substring(0, url.IndexOf(':'));

        string server = url.Substring(protocol.Length + 3,
            url.IndexOf('/', (protocol.Length + 3)) - (protocol.Length + 3));

        string resource = url.Substring(server.Length + protocol.Length + 3,
            url.Length - (server.Length + protocol.Length + 3));

        Console.WriteLine("[protocol] = {0}", protocol);
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] = {0}", resource);
    }
}