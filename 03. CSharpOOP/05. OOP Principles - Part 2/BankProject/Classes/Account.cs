namespace BankProject.Classes
{
    using Interfaces;

    public abstract class Account : IDepositable
    {
        private decimal balance;
        private CustomerType type;
        private decimal interest; // monthly based

        public Account(string customerName, CustomerType type, decimal interest, decimal amount)
        {
            this.Customer = customerName;
            this.Type = type;
            this.Interest = interest;
            this.Balance = amount;
        }

        public string Customer { get; private set; }

        public CustomerType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public decimal Balance
        {
            get { return this.balance; }
            internal set { this.balance = value; }
        }

        public decimal Interest
        {
            get { return this.interest; }
            internal set { this.interest = value; }
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        internal abstract decimal CalculateInterest(int months);
    }
}
