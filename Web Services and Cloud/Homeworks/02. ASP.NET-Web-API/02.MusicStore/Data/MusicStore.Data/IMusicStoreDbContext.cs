namespace MusicStore.Data
{
    using System.Data.Entity;
    using MusicStore.Models;
    using System.Data.Entity.Infrastructure;

    public interface IMusicStoreDbContext
    {
        IDbSet<Album> Albums { get; set; }

        IDbSet<Artist> Artists { get; set; }

        IDbSet<Song> Songs { get; set; }

        DbEntityEntry<T> Entry<T>(T entity) where T : class;

        void SaveChanges();

        IDbSet<T> Set<T>() where T : class;
    }
}