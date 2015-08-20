using System;

namespace BankAccounts
{
    class AccDeposit : Account, IWithdraw
    {
        public AccDeposit(Customer customer, double balance, double interestRate, int durationMonths)
            : base(customer, balance, interestRate, durationMonths)
        {
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Withdraw amount must be greater than 0");
            }
            this.Balance -= amount;
        }

        public override double CalculateInterestAmount()
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            return base.CalculateInterestAmount();
        }
    }
}
