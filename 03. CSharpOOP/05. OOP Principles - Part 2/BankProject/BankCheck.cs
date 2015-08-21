namespace BankProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using BankProject.Classes;

    public class BankCheck
    {
        public static void Main()
        {
            var myAccount = new DepositAccount("G Alex", CustomerType.Companie, 4.6m, 10000);
            Console.WriteLine(myAccount.CalculateInterest(15));
        }
    }
}
