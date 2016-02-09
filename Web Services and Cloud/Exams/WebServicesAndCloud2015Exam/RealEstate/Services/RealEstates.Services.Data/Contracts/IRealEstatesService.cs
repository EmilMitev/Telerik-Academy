namespace RealEstate.Services.Data.Contracts
{
    using System.Linq;
    using Common.Models;
    using RealEstate.Models;

    public interface IRealEstatesService
    {
        IQueryable<RealEstateModel> Add(RealEstateDetailsRequestModel model);
        IQueryable<RealEstateModel> All(int page, int pageSize);
        IQueryable<RealEstateModel> ById(int id);
    }
}