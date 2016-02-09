namespace MusicStore.Services.Data
{
    using System.Linq;
    using MusicStore.Models;
    using MusicStore.Data.Repositories;
    using MusicStore.Data;

    public class ArtistsService : IArtistsService
    {
        private readonly IGenericRepository<Artist> artists;

        public ArtistsService(IGenericRepository<Artist> artistRepo)
        {
            this.artists = artistRepo;
        }

        // This is without ninject
        //public ArtistsService()
        //{
        //    var db = new MusicStoreDbContext();
        //    this.artists = new GenericRepository<Artist>(db);
        //}

        public int Add(string name, string country)
        {
            var newArtist = new Artist
            {
                Name = name, 
                Country = country
            };

            this.artists.Add(newArtist);
            this.artists.SaveChanges();

            return newArtist.Id;
        }

        public IQueryable<Artist> All(int page = 1, int pageSize = 10)
        {
            return this.artists
                .All()
                .OrderBy(s => s.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }

        public IQueryable<Artist> ById(int id)
        {
            return this.artists
              .All()
              .Where(s => s.Id == id);
        }

        public int Delete(int id)
        {
            var artistToDelete = this.artists.All().FirstOrDefault(s => s.Id == id);

            if (artistToDelete == null)
            {
                return 0;
            }

            this.artists.Delete(artistToDelete);
            this.artists.SaveChanges();

            return artistToDelete.Id;
        }

        public int Update(int id, string name, string country)
        {
            var artistYoUpdate = this.artists.All().FirstOrDefault(s => s.Id == id);

            if (artistYoUpdate == null)
            {
                return 0;
            }

            artistYoUpdate.Name = name;
            artistYoUpdate.Country = country;

            this.artists.Update(artistYoUpdate);
            this.artists.SaveChanges();

            return artistYoUpdate.Id;
        }
    }
}