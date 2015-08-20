namespace BankAccounts
{
    class AccMortgage : Account, IDeposit
    {
        public AccMortgage(Customer customer, double balance, double interestRate, int durationMonths)
            : base(customer, balance, interestRate, durationMonths)
        {

        }

        public override double CalculateInterestAmount()
        {
            if (this.Customer.GetType() == typeof(CustIndividual))
            {
                int motnthafter6m;
                if (this.DurationMonths >= 6)
                {
                    motnthafter6m = this.DurationMonths - 6;
                }
                else
                {
                    motnthafter6m = 0;
                }

                double ammount = ((this.DurationMonths - motnthafter6m) *
                    this.InterestRate * 0) + motnthafter6m * this.InterestRate*this.Balance;

                return ammount;
            }
            if (this.Customer.GetType() == typeof(CustCompany))
            {
                int motnthafter12m;
                if (this.DurationMonths >= 12)
                {
                    motnthafter12m = this.DurationMonths - 12;
                }
                else
                {
                    motnthafter12m = 0;
                }

                double ammount = ((this.DurationMonths - motnthafter12m) *
                    this.InterestRate * 0.5) + motnthafter12m * this.InterestRate * this.Balance;

                return ammount;
            }
            return base.CalculateInterestAmount();
        }
    }
}
