using System;

/*  Problem 11. Bank Account Data
    A bank account has a holder name (first name, middle name and last name), available 
    amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
    Declare the variables needed to keep the information for a single bank account using 
    the appropriate data types and descriptive names.
 */

public class BankAccountData
{
    public static void Main()
    {
        string firstName = "Pesho";
        string middleName = "Stoqnov";
        string lastName = "Peshev";
        string holderName = firstName + " " + middleName + " " + lastName;
        int balance = 2000000;
        string bankName = "DSK";
        string IBAN = "BG 53 BNBG 9211 4524 1431 02";
        long creditCard1 = 4012888888881881;
        long creditCard2 = 3782822463100053;
        long creditCard3 = 4844264826820130;

        Console.WriteLine("Holder name: " + holderName);
        Console.WriteLine("Available amount: " + balance + " BGN at " + bankName + " BANK");
        Console.WriteLine("IBAN:" + IBAN + " \nHolder credit card numbers: \n\tVisa - " + creditCard1 + " \n\tVisa Electron - " + creditCard2 + "\n\tAmerican Express - " + creditCard3);
    }
}