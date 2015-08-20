using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer comp = new CustCompany("MyCompany", "bg6r57657857867");
            Customer indiv = new CustIndividual("new", " customer", "6598988989");

            List<Account> accs = new List<Account>
            {
                new AccMortgage(comp, 125, 0.005, 15),
                new AccDeposit(comp, 1125, 0.005, 15),
                new AccLoan(comp, 125, 0.005, 15)
            };
            foreach (var acc in accs)
            {
                Console.WriteLine(acc.CalculateInterestAmount());
            }
        }
    }
}
