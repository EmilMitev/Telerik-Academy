namespace RealEstate.Services.Data.Contracts
{
    using System.Linq;
    using Common.Models;
    using RealEstate.Models;

    public interface ICommentsService
    {
        IQueryable<Comment> Add(CommentsDetailsRequestModel model, string username);
        IQueryable<Comment> All(string username, int page, int pageSize);
        IQueryable<Comment> All(int id, int page, int pageSize);
    }
}