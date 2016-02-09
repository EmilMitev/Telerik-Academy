namespace EfConsoleApp
{
    using System;
    using System.Linq;

    public class TaskEight
    {
        public static void Execute(NorthwindEntities dbConnection)
        {
            foreach (var employee in dbConnection.Employees.Include("Territories"))
            {
                var correspondingTerritories = employee.Territories.Select(c => c.TerritoryID);
                var correspondingTerritoriesAsString = string.Join(", ", correspondingTerritories);
                Console.WriteLine("\t{0} -> Territory IDs: {1}", employee.FirstName, correspondingTerritoriesAsString);
            }
        }
    }
}
