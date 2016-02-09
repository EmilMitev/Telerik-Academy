namespace BankAccounts
{
    using System;

    internal class Mortgage : Account, IIntrest
    {
         public Mortgage(Customer customer, decimal balance, decimal interest)
            : base(customer, balance, interest)
        {
        }

         public double CalculateInterest(int months)
         {
             if (months <= 0)
             {
                 throw new ArithmeticException("Negative period.");
             }

             if (base.Customer.Type == Type.Individual)
             {
                 if (months <= 6)
                 {
                     return 0;
                 }

                 months -= 6;

                 return (double)base.Interest * months;
             }
             else
             {
                 if (months <= 12)
                 {
                     return (double)(base.Interest / 2) * months;
                 }

                 months -= 12;

                 return ((double)base.Interest * months) + ((double)(base.Interest / 2) * 12);
             }
         }
    }
}
