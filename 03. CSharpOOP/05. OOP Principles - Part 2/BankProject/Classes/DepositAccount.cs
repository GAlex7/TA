namespace BankProject.Classes
{
    using Interfaces;

    public class DepositAccount : Account, IDepositable, IWithdrawable
    {
        public DepositAccount(string customerName, CustomerType type, decimal interest, decimal amount)
            : base(customerName, type, interest, amount)
        {
        }

        public decimal Withdraw(decimal amount)
        {
            if (this.Balance > amount)
            {
                this.Balance -= amount;
                return amount;
            }

            return 0;
        }

        // Deposit accounts have no interest if their balance is positive and less than 1000.
        internal override decimal CalculateInterest(int months)
        {
            if (this.Balance > 1000)
            {
                return this.Interest * months * this.Balance / 100;
            }

            return 0;
        }
    }
}
