using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your name.");
        string name = Console.ReadLine();
        HelloName(name);
    }

    public static void HelloName(string name)
    {
        Console.WriteLine("Hello, {0}!",name);
    }
}