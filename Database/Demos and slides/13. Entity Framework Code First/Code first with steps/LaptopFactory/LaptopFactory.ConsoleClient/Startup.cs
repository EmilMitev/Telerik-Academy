namespace LaptopFactory.ConsoleClient
{

    using System.Data.Entity;
    using System.Linq;

    using LaptopFactory.Data;
    using LaptopFactory.Data.Migrations;

    public class Startup
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<LaptopFactoryDbContext, Configuration>());

            var db = new LaptopFactoryDbContext();

            db.Laptops.Count();
        }
    }
}
