using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class Customer
    {
        private string fName;
        private string lName;

        public Customer()
        {

        }

        public Customer(string fName, string lName)
        {
            this.FName = fName;
            this.LName = lName;
        }

        public string FName
        {
            get { return fName; }
            private set { fName = value; }
        }

        public string LName
        {
            get { return lName; }
            private set { lName = value; }
        }
    }
}
