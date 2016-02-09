namespace MusicStore.Services.Data
{
    using System.Linq;
    using MusicStore.Models;

    public interface IArtistsService
    {
        IQueryable<Artist> All(int page = 1, int pageSize = 10);

        IQueryable<Artist> ById(int id);

        int Add(string name, string country);

        int Delete(int id);

        int Update(int id, string name, string country);
    }
}