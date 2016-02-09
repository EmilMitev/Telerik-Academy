namespace RealEstate.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using RealEstate.Models;
    using System.Data.Entity;

    public class RealEstateDbContext : IdentityDbContext<User>, IRealEstateDbContext
    {
        public RealEstateDbContext()
            : base("RealEstateConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<RealEstateModel> RealEstates { get; set; }

        public virtual IDbSet<Comment> Comments { get; set; }

        public virtual IDbSet<Rating> Ratings { get; set; }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public new void SaveChanges()
        {
            // If you have exception here is because you don't have that RealEstateId in table RealEstateModel
            base.SaveChanges();
        }

        public static RealEstateDbContext Create()
        {
            return new RealEstateDbContext();
        }
    }
}