namespace EfConsoleApp
{
    using System.Collections.Generic;
    using System.Linq;

    public class TaskTwo
    {
        public static void ExecuteInsert(NorthwindEntities dbConnection, RandomGenerator random)
        {
            Customer customer;
            var customers = new List<Customer>();

            for (int i = 0; i < 5; i++)
            {
                customer = new Customer
                {
                    CustomerID = random.GetRandomUpperString(5),
                    CompanyName = random.GetRandomString(15),
                    PostalCode = "666"
                };

                customers.Add(customer);
            }

            DAO.Insert(dbConnection, customers);
        }

        public static void ExecuteDelete(NorthwindEntities dbConnection)
        {
            var customersToDelete = dbConnection.Customers
                                                .Where(c => c.PostalCode == "666")
                                                .ToList();

            DAO.Delete(dbConnection, customersToDelete);
        }

        public static void ExecuteUpdate(NorthwindEntities dbConnection)
        {
            var customersToUpdate = dbConnection.Customers
                                                .Where(c => c.PostalCode == "666")
                                                .ToList();

            string postalCode = "777";

            DAO.Update(dbConnection, customersToUpdate, postalCode);
        }
    }
}
