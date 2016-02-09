namespace Common.Models
{
    using RealEstate.Models;

    public class RealEstateDetailsRequestModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Address { get; set; }

        public string Contact { get; set; }

        public decimal? SellingPrice { get; set; }

        public decimal? RentingPrice { get; set; }

        public RealEstateType Type { get; set; }
    }
}
