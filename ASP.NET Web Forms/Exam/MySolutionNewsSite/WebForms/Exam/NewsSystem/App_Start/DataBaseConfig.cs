namespace NewsSystem
{
    using NewsSystem.Migrations;
    using NewsSystem.Models;
    using System.Data.Entity;

    public class DataBaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<NewsSystemDbContext, Configuration>());

            NewsSystemDbContext.Create().Database.Initialize(true);
        }
    }
}
