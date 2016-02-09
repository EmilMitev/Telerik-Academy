namespace RealEstate.Services.Data
{
    using Common.Models;
    using RealEstate.Data;
    using RealEstate.Data.Repositories;
    using RealEstate.Models;
    using RealEstate.Services.Data.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CommentsService : ICommentsService
    {
        private readonly IGenericRepository<Comment> comments;
        private readonly IGenericRepository<User> user;


        public CommentsService()
        {
            var db = new RealEstateDbContext();
            this.comments = new GenericRepository<Comment>(db);
            this.user = new GenericRepository<User>(db);
        }

        public IQueryable<Comment> All(int id, int page, int pageSize)
        {
            return this.comments
                .All()
                .Where(s => s.RealEstateId == id)
                .OrderBy(s => s.Id)
                .Skip(page * pageSize)
                .Take(pageSize);
        }

        public IQueryable<Comment> All(string username, int page, int pageSize)
        {
            return this.comments
                .All()
                .Where(s => s.User.UserName == username)
                .OrderBy(s => s.Id)
                .Skip(page * pageSize)
                .Take(pageSize);
        }

        public IQueryable<Comment> Add(CommentsDetailsRequestModel model, string username)
        {
            var list = new List<Comment>();

            var id = this.user.All().FirstOrDefault(u => u.UserName == username).Id;

            var newComment = new Comment
            {
                Content = model.Content,
                RealEstateId = model.RealEstateId,
                CreatedOn = DateTime.Now,
                UserId = id
            };

            this.comments.Add(newComment);
            list.Add(newComment);
            this.comments.SaveChanges();

            return list.AsQueryable();
        }
    }
}
