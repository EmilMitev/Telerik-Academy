namespace RealEstate.Api.Controllers
{
    using Common.Models;
    using RealEstate.Api.Models;
    using RealEstate.Services.Data;
    using RealEstate.Services.Data.Contracts;
    using System.Linq;
    using System.Web.Http;

    public class CommentsController : ApiController
    {
        private readonly ICommentsService commentsService;

        public CommentsController(ICommentsService commentsService)
        {
            this.commentsService = commentsService;
        }

        public CommentsController()
            : this(new CommentsService())
        {
        }

        [Authorize]
        public IHttpActionResult Get(int id, int skip = 0, int take = 10)
        {
            var result = this.commentsService
                .All(id, skip, take)
                .Select(AuthorizeCommentsByIdDetailsResponseModel.FromModel)
                .ToList();

            return this.Ok(result);
        }

        [Authorize]
        [HttpGet]
        [Route("api/Comments/ByUser/{username}")]
        public IHttpActionResult Get(string username, int skip = 0, int take = 10)
        {
            var result = this.commentsService
                .All(username, skip, take)
                .Select(AuthorizeCommentsByIdDetailsResponseModel.FromModel)
                .ToList();

            return this.Ok(result);
        }

        [Authorize]
        public IHttpActionResult Post([FromBody]CommentsDetailsRequestModel comment)
        {
            if (comment == null)
            {
                return this.BadRequest();
            }

            if (!this.ModelState.IsValid)
            {
                return BadRequest(this.ModelState);
            }

            var result = this.commentsService
                .Add(comment, this.User.Identity.Name)
                .Select(CommentsDetailsResponseModel.FromModel)
                .FirstOrDefault();

            result.Username = this.User.Identity.Name;

            return this.Ok(result);
        }
    }
}
