using System.Collections.Generic;
using Common.Models;
using RealEstate.Data.Repositories;
using RealEstate.Models;
using RealEstate.Data;
using System.Linq;
using System;

namespace RealEstateWCF.Api
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "top" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select top.svc or top.svc.cs at the Solution Explorer and start debugging.
    public class Top : ITop
    {
        private readonly IGenericRepository<User> user;
        private readonly IGenericRepository<Rating> ratings;

        public Top()
        {
            var db = new RealEstateDbContext();
            this.user = new GenericRepository<User>(db);
            this.ratings = new GenericRepository<Rating>(db);
        }

        public IEnumerable<WcfUserResponseModel> GetAll()
        {
            throw new NotImplementedException();
        }

    }
}
