namespace RealEstate.Api.Models
{
    using RealEstate.Models;
    using System;
    using System.Linq.Expressions;

    public class RealEstatePageDetailsResponseModel
    {

        public static Expression<Func<RealEstateModel, RealEstatePageDetailsResponseModel>> FromModel
        {
            get
            {
                return s => new RealEstatePageDetailsResponseModel
                {
                    Id = s.Id,
                    Title = s.Title,
                    SellingPrice = s.SellingPrice,
                    RentingPrice = s.RentingPrice,
                    CanBeSold = s.CanBeSold,
                    CanBeRented = s.CanBeRented
                };
            }
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public decimal? SellingPrice { get; set; }

        public decimal? RentingPrice { get; set; }

        public bool CanBeSold { get; set; }

        public bool CanBeRented { get; set; }
    }
}
