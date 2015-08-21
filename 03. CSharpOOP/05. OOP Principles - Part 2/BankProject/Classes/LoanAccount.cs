namespace BankProject.Classes
{
    using Interfaces;

    public class LoanAccount : Account, IDepositable
    {
        public LoanAccount(string customerName, CustomerType type, decimal interest, decimal amount)
            : base(customerName, type, interest, amount)
        {
        }

        /* Loan accounts have no interest for the 
         first 3 months if are held by individuals AND
         first 2 months if are held by a company. */
        internal override decimal CalculateInterest(int months)
        {
            if (this.Type == CustomerType.Individual)
            {
                return this.Interest * (months - 3) * this.Balance;
            }
            else
            {
                return this.Interest * (months - 2) * this.Balance;
            }
        }
    }
}
