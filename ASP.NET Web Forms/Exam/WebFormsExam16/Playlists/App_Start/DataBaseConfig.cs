namespace Playlists
{
    using Migrations;
    using Models;
    using System.Data.Entity;

    public class DataBaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<PlaylistDbContext, Configuration>());

            PlaylistDbContext.Create().Database.Initialize(true);
        }
    }
}
