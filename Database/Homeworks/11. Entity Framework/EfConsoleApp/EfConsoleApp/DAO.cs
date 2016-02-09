namespace EfConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DAO
    {
        public static void Insert(NorthwindEntities dbConnection, List<Customer> custormers)
        {
            var addedRows = 0;
            foreach (var customer in custormers)
            {
                dbConnection.Customers.Add(customer);
                var affectedRows = dbConnection.SaveChanges();
                addedRows += affectedRows;
            }

            Console.WriteLine("{0} rows has been added.", addedRows);
        }

        public static void Update(NorthwindEntities dbConnection, List<Customer> customers, string postalCode)
        {
            var updatedRows = 0;
            foreach (var customer in customers)
            {
               var customerToUpdate = dbConnection.Customers.Where(c => c.PostalCode == customer.PostalCode && c.CustomerID == customer.CustomerID).FirstOrDefault();
                customerToUpdate.PostalCode = postalCode;
                var affectedRows = dbConnection.SaveChanges();
                updatedRows += affectedRows;
            }

            Console.WriteLine("{0} rows has been updated.", updatedRows);
        }

        public static void Delete(NorthwindEntities dbConnection, List<Customer> customers)
        {
            var deletedRows = 0;
            foreach (var customer in customers)
            {
                dbConnection.Customers.Remove(customer);
                var affectedRows = dbConnection.SaveChanges();
                deletedRows += affectedRows;
            }

            Console.WriteLine("{0} rows has been deleted.", deletedRows);
        }
    }
}