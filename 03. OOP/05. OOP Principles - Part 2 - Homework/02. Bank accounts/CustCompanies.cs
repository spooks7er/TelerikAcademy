using System;

namespace BankAccounts
{
    public class CustCompany : Customer
    {
        private string compName;

        private string bulstat;

        public CustCompany(string compName, string bulstat)
        {
            this.CompName = compName;
            this.Bulstat = bulstat;
        }

        public CustCompany(string compName, string fName, string lName, string bulstat)
            : base(fName, lName)
        {
            this.CompName = compName;
            this.Bulstat = bulstat;
        }

        public string CompName
        {
            get { return compName; }
            set { compName = value; }
        }

        public string Bulstat
        {
            get { return bulstat; }
            private set
            {
                // Do whatever to check for bulstat validity
                bulstat = value;
            }
        }
    }
}
