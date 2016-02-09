namespace RealEstate.Data
{
    using System.Data.Entity;
    using RealEstate.Models;
    using System.Data.Entity.Infrastructure;

    public interface IRealEstateDbContext
    {
        IDbSet<Comment> Comments { get; set; }

        IDbSet<Rating> Ratings { get; set; }

        IDbSet<Models.RealEstateModel> RealEstates { get; set; }

        void SaveChanges();

        DbEntityEntry<T> Entry<T>(T entity) where T : class;

        IDbSet<T> Set<T>() where T : class;
    }
}