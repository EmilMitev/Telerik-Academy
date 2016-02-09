namespace RealEstate.Api.Controllers
{
    using RealEstate.Api.Models;
    using RealEstate.Services.Data;
    using RealEstate.Services.Data.Contracts;
    using System.Linq;
    using System.Web.Http;
    using Common.Models;

    public class RealEstatesController : ApiController
    {
        private readonly IRealEstatesService estateService;

        public RealEstatesController(IRealEstatesService estateService)
        {
            this.estateService = estateService;
        }

        public RealEstatesController()
            : this(new RealEstatesService())
        {
        }


        public IHttpActionResult Get(int skip = 0, int take = 10)
        {
            var result = this.estateService
                .All(skip, take)
                .Select(RealEstatePageDetailsResponseModel.FromModel)
                .ToList();

            return this.Ok(result);
        }

        public IHttpActionResult Get(int id)
        {
            var user = this.User.Identity.Name;
            
            if (user == null)
            {
                var result = this.estateService
                    .ById(id)
                    .Select(RealEstateByIdDetailsResponseModel.FromModel)
                    .FirstOrDefault();

                return this.Ok(result);
            }
            else
            {
                var result = this.estateService
                   .ById(id)
                   .Select(AuthorizeRealEstateByIdDetailsResponseModel.FromModel)
                   .FirstOrDefault();

                return this.Ok(result);
            }
        }

        [Authorize]
        public IHttpActionResult Post([FromBody]RealEstateDetailsRequestModel realEstate)
        {
            if (realEstate == null)
            {
                return this.BadRequest();
            }

            if (!this.ModelState.IsValid)
            {
                return BadRequest(this.ModelState);
            }

            var result = this.estateService
                 .Add(realEstate)
                 .Select(RealEstateDetailsResponseModel.FromModel)
                 .FirstOrDefault();

            return this.Created("api/RealEstates", result);
        }
    }
}
