namespace RealEstate.Services.Data
{
    using Models;
    using RealEstate.Data;
    using RealEstate.Data.Repositories;
    using Contracts;
    using System.Linq;
    using Common.Models;
    using System.Collections.Generic;

    public class RealEstatesService : IRealEstatesService
    {
        private readonly IGenericRepository<RealEstateModel> realEstateModel;

        //public RealEstatesService(IGenericRepository<RealEstateModel> realEstatesRepo)
        //{
        //    this.realEstateModel = realEstatesRepo;
        //}

        public RealEstatesService()
        {
            var db = new RealEstateDbContext();
            this.realEstateModel = new GenericRepository<RealEstateModel>(db);
        }

        public IQueryable<RealEstateModel> All(int page, int pageSize)
        {
            return this.realEstateModel
                .All()
                .OrderByDescending(s => s.Id)
                .Skip(page * pageSize)
                .Take(pageSize);
        }

        public IQueryable<RealEstateModel> ById(int id)
        {
            return this.realEstateModel
              .All()
              .Where(s => s.Id == id);
        }

        public IQueryable<RealEstateModel> Add(RealEstateDetailsRequestModel model)
        {
            var list = new List<RealEstateModel>();

            var newRealEstate = new RealEstateModel
            {
                Title = model.Title,
                Description = model.Description,
                Address = model.Address,
                Contact = model.Contact,
                SellingPrice = model.SellingPrice,
                RentingPrice = model.RentingPrice,
                Type = model.Type
            };

            this.realEstateModel.Add(newRealEstate);
            list.Add(newRealEstate);
            this.realEstateModel.SaveChanges();

            return list.AsQueryable();
        }
    }
}