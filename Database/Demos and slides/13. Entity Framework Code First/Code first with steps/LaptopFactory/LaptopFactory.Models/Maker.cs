namespace LaptopFactory.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Maker
    {
        private ICollection<Laptop> laptops;

        public Maker()
        {
            this.Laptops = new HashSet<Laptop>();
        }

        public int Id { get; set; }

        [StringLength(40)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        [StringLength(11)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

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
    }
}
