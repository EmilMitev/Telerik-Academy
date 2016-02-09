namespace EfConsoleApp
{
    using System;
    using System.Linq;

    public class TaskThree
    {
        public static void Execute(NorthwindEntities dbConnection)
        {
            var orders = dbConnection.Orders
                        .Where(o => o.OrderDate.Value.Year == 1997 && o.ShipCountry == "Canada")
                        .Select(o => new
                        {
                            CustomerName = o.Customer.ContactName,
                            OrderDate = o.OrderDate,
                            ShipCountry = o.ShipCountry
                        })
                        .OrderBy(o => o.CustomerName)
                        .ToList();

            foreach (var order in orders)
            {
                Console.WriteLine("\tName: {0}, from {1} - order date: {2}", order.CustomerName, order.ShipCountry, order.OrderDate);
            }

            Console.WriteLine("\tOrder count: {0}", orders.Count);
        }
    }
}
