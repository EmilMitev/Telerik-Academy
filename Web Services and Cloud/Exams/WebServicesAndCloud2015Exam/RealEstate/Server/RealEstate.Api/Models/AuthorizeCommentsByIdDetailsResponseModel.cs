namespace RealEstate.Api.Models
{
    using RealEstate.Models;
    using System;
    using System.Linq.Expressions;

    public class AuthorizeCommentsByIdDetailsResponseModel
    {
        public static Expression<Func<Comment, AuthorizeCommentsByIdDetailsResponseModel>> FromModel
        {
            get
            {
                return s => new AuthorizeCommentsByIdDetailsResponseModel
                {
                    Content = s.Content,
                    CreatedOn = s.CreatedOn,
                    User = s.User.UserName
                };
            }
        }

        public string Content { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string User { get; set; }
    }
}
