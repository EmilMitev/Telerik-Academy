namespace MusicStore.Api
{
    using MusicStore.Data;
    using MusicStore.Data.Migrations;
    using System.Data.Entity;

    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MusicStoreDbContext, Configuration>());
            MusicStoreDbContext.Create().Database.Initialize(true);
        }
    }
}
