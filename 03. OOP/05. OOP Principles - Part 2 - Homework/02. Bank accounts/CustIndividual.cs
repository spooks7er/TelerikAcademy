using System;

namespace BankAccounts
{
    public class CustIndividual : Customer
    {
        private string egn;

        public CustIndividual(string fName, string lName, string egn)
            : base(fName, lName)
        {
            this.EGN = egn;
        }

        public string EGN
        {
            get { return egn; }
            private set
            {
                if (value.Length < 10 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("EGN must be exactly 10 digits.");
                }
                foreach (var digit in value)
                {
                    if (!char.IsDigit(digit))
                    {
                        throw new ArgumentException("EGN must contain only digits.");
                    }
                }
                egn = value;
            }
        }
    }
}
