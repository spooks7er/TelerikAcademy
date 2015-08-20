using System;

namespace BankAccounts
{
    public abstract class Account : IDeposit
    {
        private Customer customer;
        private double balance;
        private double interestRate;
        private int durationMonths;


        public Account(Customer customer, double balance, double interestRate, int durationMonths)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.DurationMonths = durationMonths;
        }

        public Customer Customer
        {
            get { return customer; }
            private set { customer = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        public int DurationMonths
        {
            get { return durationMonths; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Duration in Months be greater than 0.");
                }
                durationMonths = value;
            }
        }

        public virtual double CalculateInterestAmount()
        {
            return this.DurationMonths * InterestRate*this.Balance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Deposit amount must be greater than 0");
            }
            this.Balance += amount;
        }
    }
}
