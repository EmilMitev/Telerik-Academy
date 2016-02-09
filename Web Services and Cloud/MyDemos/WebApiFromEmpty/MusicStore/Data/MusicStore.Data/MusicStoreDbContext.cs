namespace MusicStore.Data
{
    using Models;
    using System.Data.Entity;

    public class MusicStoreDbContext : DbContext, IMusicStoreDbContext
    {
        public MusicStoreDbContext()
            : base("MusicStoreDb")
        {
        }

        public virtual IDbSet<Album> Albums { get; set; }

        public virtual IDbSet<Artist> Artists { get; set; }

        public virtual IDbSet<Song> Songs { get; set; }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }

        public static MusicStoreDbContext Create()
        {
            return new MusicStoreDbContext();
        }
    }
}
