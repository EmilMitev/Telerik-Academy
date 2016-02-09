namespace MusicStore.Api
{
    using System.Linq;
    using MusicStore.Api.Models;
    using System.ServiceModel;
    using System.Collections.Generic;

    public class ArtistService : BaseService, IArtistService
    {

        public IEnumerable<ArtistsDetailsResponseModel> GetAll()
        {
            var result = this.Artists
                    .All()
                    .OrderBy(s => s.Id)
                    .Select(ArtistsDetailsResponseModel.FromModel)
                    .ToList();

            return result.AsQueryable();
        }

        public ArtistsDetailsResponseModel GetById(string id)
        {
            var result = this.Artists
                  .All()
                  .Where(s => s.Id == int.Parse(id))
                  .Select(ArtistsDetailsResponseModel.FromModel)
                  .FirstOrDefault();

            return result;
        }
    }
}
