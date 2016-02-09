namespace Common.Models
{
    using RealEstate.Models;
    using System;
    using System.Linq.Expressions;

    public class CommentsDetailsResponseModel
    {
        public static Expression<Func<Comment, CommentsDetailsResponseModel>> FromModel
        {
            get
            {
                return s => new CommentsDetailsResponseModel
                {
                  Content = s.Content,
                  CreatedOn = s.CreatedOn
                };
            }
        }

        public string Content { get; set; }

        public string Username { get; set; }

        public DateTime? CreatedOn { get; set; }
    }
}
