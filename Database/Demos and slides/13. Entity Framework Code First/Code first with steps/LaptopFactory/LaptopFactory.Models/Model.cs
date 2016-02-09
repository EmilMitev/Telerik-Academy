namespace LaptopFactory.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Model
    {
        private ICollection<Laptop> laptops;

        private ICollection<Order> orders;

        public Model()
        {
            this.Laptops = new HashSet<Laptop>();
            this.Orders = new HashSet<Order>();
        }

        public int Id { get; set; }

        [StringLength(40)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        [StringLength(30)]
        public string CPU { get; set; }

        public int RAM { get; set; }

        public int HDD { get; set; }

        public virtual ICollection<Laptop> Laptops
        {
            get
            {
                return this.laptops;
            }

            set
            {
                this.laptops = value;
            }
        }

        public virtual ICollection<Order> Orders
        {
            get
            {
                return this.orders;
            }

            set
            {
                this.orders = value;
            }
        }
    }
}
