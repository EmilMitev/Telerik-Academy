namespace MusicStore.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using MusicStore.Models;
    using System.Data.Entity;

    public class MusicStoreDbContext : IdentityDbContext<User>, IMusicStoreDbContext
    {
        public MusicStoreDbContext()
            : base("MusicStore", throwIfV1Schema: false)
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
