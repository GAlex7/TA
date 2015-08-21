//Problem 11. Bank Account Data

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
//bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and
//descriptive names.

using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Ivanov";
        string lastName = "Ivanov";
        object holderName = firstName + " " + middleName + " " + lastName;
        decimal accountBalance = 255.55m;
        string bankName = "Some Bank";
        string iban = "BG22FINV12345678901234";
        string bic = "FINVBG";
        ulong creditCardNumber1 = 123456789000001u;
        ulong creditCardNumber2 = 123456789000002u;
        ulong creditCardNumber3 = 123456789000003u;
        Console.WriteLine("Account holder: " + holderName
            + "\nBalance: " + accountBalance
            + " BGN\nBank: " + bankName
            + "\nIBAN: " + iban
            + "\nBIC: " + bic
            + "\nCredit Card 1: " + creditCardNumber1
            + "\nCredit Card 2: " + creditCardNumber2
            + "\nCredit Card 3: " + creditCardNumber3);
    }
}