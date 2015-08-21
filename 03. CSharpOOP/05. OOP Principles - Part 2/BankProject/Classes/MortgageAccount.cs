namespace BankProject.Classes
{
    using Interfaces;

    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(string customerName, CustomerType type, decimal interest, decimal amount)
            : base(customerName, type, interest, amount)
        {
        }

        // Mortgage accounts have 
        //  ½ interest for the first 12 months for companies AND
        // no interest for the first  6 months for individuals.
        internal override decimal CalculateInterest(int months)
        {
            decimal result = 0;
            if (this.Type == CustomerType.Companie)
            {
                if (months > 12)
                {
                    result = (this.Interest * this.Balance * (months - 12)) +
                        (this.Interest / 2 * this.Balance * 12);
                }
                else
                {
                    result = this.Interest / 2 * this.Balance * months;
                }
            }
            else
            {
                return this.Interest * (months - 6m) * this.Balance;
            }

            return result;
        }
    }
}
