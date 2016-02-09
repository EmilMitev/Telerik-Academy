namespace MusicStore.Api.Controllers
{
    using Models;
    using Services.Data;
    using System.Linq;
    using System.Web.Http;

    public class ArtistsController : ApiController
    {
        private readonly IArtistsService artists;

        public ArtistsController(IArtistsService artistService)
        {
            this.artists = artistService;
        }

        // Without ninject
        //public ArtistsController()
        //    : this(new ArtistsService())
        //{
        //}
        [Authorize]
        public IHttpActionResult Get()
        {
            var result = this.artists
                .All()
                .Select(ArtistsDetailsResponseModel.FromModel)
                .ToList();

            return this.Ok(result);
        }

        public IHttpActionResult Get(int id)
        {

            var result = this.artists
                .ById(id)
                .Select(ArtistsDetailsResponseModel.FromModel)
                .FirstOrDefault();

            return this.Ok(result);
        }

        public IHttpActionResult Post([FromBody]ArtistsDetailsResponseModel artist)
        {
            if (artist == null)
            {
                return this.BadRequest();
            }

            if (!this.ModelState.IsValid)
            {
                return BadRequest(this.ModelState);
            }

            var result = this.artists
                .Add(artist.Name,
                     artist.Country);

            return this.Ok(result);
        }

        public IHttpActionResult Delete(int id)
        {
            var result = this.artists.Delete(id);

            if (result == 0)
            {
                return this.BadRequest("Artist doesnt exist!");
            }

            return this.Ok(string.Format("Artist {0} deleted!", result));
        }

        public IHttpActionResult Put(int id, [FromBody] ArtistsDetailsResponseModel artist)
        {
            if (artist == null)
            {
                return this.BadRequest();
            }

            if (!this.ModelState.IsValid)
            {
                return BadRequest(this.ModelState);
            }

            var result = this.artists.Update(id, artist.Name, artist.Country);

            if (result == 0)
            {
                return this.BadRequest("Artist doesnt exist!");
            }

            return this.Ok(string.Format("Artist {0} updated!", result));
        }
    }
}