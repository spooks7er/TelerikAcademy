using System;

//Problem 11. Bank Account Data
//• A bank account has a holder name (first name, middle name and last name), 
//available amount of money (balance), 
//bank name, IBAN, 3 credit card numbers associated with the account.
//• Declare the variables needed to keep the information for a 
//single bank account using the appropriate data types and descriptive names.

class Program
{
    static void Main(string[] args)
    {
        string fname = "Eric";
        string mname = "Theodore";
        string lname = "Cartman";
        decimal balance = 5.95m;
        string bankname = "Bank of Southpark";
        string IBAN = "ME25505000012345678951";
        ulong card1 = 5646654656546546;
        ulong card2 = 6196796364961675;
        ulong card3 = 3164615846594964;
    }
}