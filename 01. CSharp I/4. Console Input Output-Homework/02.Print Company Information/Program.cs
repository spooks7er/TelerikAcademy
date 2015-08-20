using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Company Name.");
        string compname = (Console.ReadLine());
        Console.WriteLine("Enter Company address.");
        string compaddr = (Console.ReadLine());
        Console.WriteLine("Enter Company Phone number.");
        string phone = (Console.ReadLine());
        Console.WriteLine("Enter Company Fax number.");
        string fax = (Console.ReadLine());
        Console.WriteLine("Enter Company Web site.");
        string site = (Console.ReadLine());
        Console.WriteLine("Enter Manager first name.");
        string fName = (Console.ReadLine());
        Console.WriteLine("Enter Manager last name.");
        string lName = (Console.ReadLine());
        Console.WriteLine("Enter Manager age.");
        string manAge = (Console.ReadLine());
        Console.WriteLine("Enter Manager phone.");
        string manPhone = (Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine(compname);
        Console.WriteLine("Adress: " + compaddr);
        Console.WriteLine("Tel: " + phone);
        Console.WriteLine("Fax: " + fax);
        Console.WriteLine("Web site: " + site);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", fName, lName, manAge, manPhone);
    }
}