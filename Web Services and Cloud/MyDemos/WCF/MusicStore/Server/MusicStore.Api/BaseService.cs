namespace MusicStore.Api
{
    using MusicStore.Data;
    using Data.Repositories;
    using MusicStore.Models;

    public abstract class BaseService
    {
        protected BaseService()
        {
            var db = new MusicStoreDbContext();
            this.Artists = new GenericRepository<Artist>(db);
        }

        protected IGenericRepository<Artist> Artists { get; private set; }
    }
}