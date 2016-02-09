namespace BankAccounts
{
    using System;

    internal class Deposit : Account, IIntrest
    {
        public Deposit(Customer customer, decimal balance, decimal interest)
            : base(customer, balance, interest)
        {
        }

        public void Withdraw(decimal sum)
        {
            if (sum < 0)
            {
                throw new InvalidOperationException("Negative amount of money.");
            }

            if (this.Balance - sum < 0)
            {
                throw new InvalidOperationException("Insufficient Balance.");
            }

            this.Balance -= sum;
            Console.WriteLine("Amount successfully withdrawn");
        }

        public double CalculateInterest(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            else
            {
                return (double)this.Interest * months;
            }
        }
    }
}
