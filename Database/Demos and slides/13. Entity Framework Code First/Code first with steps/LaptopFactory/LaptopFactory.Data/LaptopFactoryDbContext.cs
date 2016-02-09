namespace LaptopFactory.Data
{
    using System.Data.Entity;
    using Models;

    public class LaptopFactoryDbContext : DbContext
    {
        public LaptopFactoryDbContext()
            : base("LaptopFactory")
        {
        }

        public virtual IDbSet<Model> Models { get; set; }

        public virtual IDbSet<Maker> Makers { get; set; }

        public virtual IDbSet<Laptop> Laptops { get; set; }

        public virtual IDbSet<Order> Orders { get; set; }
    }
}
