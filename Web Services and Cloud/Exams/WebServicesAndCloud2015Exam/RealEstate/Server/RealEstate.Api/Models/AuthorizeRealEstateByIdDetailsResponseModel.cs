namespace RealEstate.Api.Models
{
    using RealEstate.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    public class AuthorizeRealEstateByIdDetailsResponseModel
    {
        private ICollection<Comment> comments;

        public AuthorizeRealEstateByIdDetailsResponseModel()
        {
            comments = new HashSet<Comment>();
        }

        public static Expression<Func<RealEstateModel, AuthorizeRealEstateByIdDetailsResponseModel>> FromModel
        {
            get
            {
                return s => new AuthorizeRealEstateByIdDetailsResponseModel
                {
                    Contact = s.Contact,
                    Comments = s.Comments,
                    CreatedOn = s.CreatedOn,
                    ConstructionYear = s.ConstructionYear,
                    Address = s.Address,
                    RealEstateType = s.Type,
                    Description = s.Description,
                    Id = s.Id,
                    Title = s.Title,
                    SellingPrice = s.SellingPrice,
                    RentingPrice = s.RentingPrice,
                    CanBeSold = s.CanBeSold,
                    CanBeRented = s.CanBeRented
                };
            }
        }

        public string Contact { get; set; }

        public virtual ICollection<Comment> Comments
        {
            get { return this.comments; }
            set { this.comments = value; }
        }

        public DateTime? CreatedOn { get; set; }

        public int? ConstructionYear { get; set; }

        public string Address { get; set; }

        public RealEstateType RealEstateType { get; set; }

        public string Description { get; set; }

        public int Id { get; set; }

        public string Title { get; set; }

        public decimal? SellingPrice { get; set; }

        public decimal? RentingPrice { get; set; }

        public bool CanBeSold { get; set; }

        public bool CanBeRented { get; set; }
    }
}