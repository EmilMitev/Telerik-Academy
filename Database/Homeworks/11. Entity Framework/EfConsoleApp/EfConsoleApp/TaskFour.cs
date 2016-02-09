namespace EfConsoleApp
{
    using System;

    public class TaskFour
    {
        public static void Execute(NorthwindEntities dbConnection)
        {
            var orderCount = 0;
            var orders = dbConnection.Database.SqlQuery<OrderCountry>(@"SELECT c.ContactName AS Customer, 
                                                                        o.OrderDate AS OrderYear, 
                                                                        o.ShipCountry AS ShipCountry
                                                                        FROM Orders o
	                                                                        JOIN Customers c
		                                                                        ON o.CustomerID = c.CustomerID
                                                                        WHERE year(OrderDate) = 1997 AND ShipCountry = 'Canada'");
            foreach (var order in orders)
            {
                Console.WriteLine("\tName: {0}, from {1} - order date: {2}", order.Customer, order.ShipCountry, order.OrderYear);
                orderCount++;
            }

            Console.WriteLine("\tOrder count: {0}", orderCount);
        }
    }
}
