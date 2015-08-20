using System;

namespace BankAccounts
{
    class AccLoan : Account
    {
        public AccLoan(Customer customer, double balance, double interestRate, int durationMonths)
            : base(customer, balance, interestRate, durationMonths)
        {
        }

        public override double CalculateInterestAmount()
        {
            if (this.Customer.GetType() == typeof(CustIndividual))
            {
                int motnthafter3m;
                if (this.DurationMonths >= 3)
                {
                    motnthafter3m = this.DurationMonths - 3;
                }
                else
                {
                    motnthafter3m = 0;
                }

                double ammount = ((this.DurationMonths - motnthafter3m) *
                    this.InterestRate * 0) + motnthafter3m * this.InterestRate * this.Balance;

                return ammount;
            }
            if (this.Customer.GetType() == typeof(CustCompany))
            {
                int motnthafter2m;
                if (this.DurationMonths >= 2)
                {
                    motnthafter2m = this.DurationMonths - 2;
                }
                else
                {
                    motnthafter2m = 0;
                }

                double ammount = ((this.DurationMonths - motnthafter2m) *
                    this.InterestRate * 0) + motnthafter2m * this.InterestRate * this.Balance;

                return ammount;
            }
            return base.CalculateInterestAmount();
        }

    }
}
