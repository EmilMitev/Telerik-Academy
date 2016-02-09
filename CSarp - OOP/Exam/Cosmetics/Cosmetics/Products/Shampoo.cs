namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public class Shampoo : Product, IProduct, IShampoo
    {
        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            :base(name, brand, price, gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
        }

        public override decimal Price
        {
            get
            {
                return base.Price*this.Milliliters;
            }
            protected set
            {
                base.Price = value;
            }
        }

        public uint Milliliters { get; protected set; }

        public UsageType Usage { get; protected set; }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(base.ToString());
            builder.AppendLine(string.Format(" * Quantity: {0} ml", this.Milliliters));
            builder.AppendLine(string.Format(" * Usage: {0}", this.Usage));

            return builder.ToString().Trim();
        }
    }
}