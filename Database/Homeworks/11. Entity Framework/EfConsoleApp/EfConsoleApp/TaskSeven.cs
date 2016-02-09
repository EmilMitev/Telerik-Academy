namespace EfConsoleApp
{
    using System;
    using System.Linq;

    public class TaskSeven
    {
        public static void Execute()
        {
            var firstConection = new NorthwindEntities();
            var secondConection = new NorthwindEntities();

            var customerFromFirstCon = firstConection.Customers.First();
            var customerFromSecondCon = secondConection.Customers.First();

            Console.WriteLine("\tInital Name FisrtCon: {0} - SecondCon: {1}", customerFromFirstCon.CompanyName, customerFromSecondCon.CompanyName);

            customerFromFirstCon.CompanyName = "Mercedes";

            // Second name will win.
            customerFromSecondCon.CompanyName = "Jaguar";

            firstConection.SaveChanges();
            secondConection.SaveChanges();

            var result = new NorthwindEntities().Customers.First();
            Console.WriteLine("\tName After Change: {0}", result.CompanyName);
        }
    }
}
