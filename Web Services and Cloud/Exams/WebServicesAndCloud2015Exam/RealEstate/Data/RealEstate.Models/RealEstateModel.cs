namespace RealEstate.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class RealEstateModel
    {
        private ICollection<Comment> comments;

        public RealEstateModel()
        {
            comments = new HashSet<Comment>();
        }
        [Key]
        public int Id { get; set; }

        [MinLength(5)]
        [MaxLength(50)]
        [Required]
        public string Title { get; set; }

        [MinLength(10)]
        [MaxLength(1000)]
        [Required]
        public string Description { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Contact { get; set; }

        public decimal? SellingPrice { get; set; }

        public decimal? RentingPrice { get; set; }

        public bool CanBeSold { get; set; }

        public bool CanBeRented { get; set; }

        public DateTime? CreatedOn { get; set; }

        public RealEstateType Type { get; set; }

        [Range(1800, 3000)]
        public int? ConstructionYear { get; set; }

        public virtual ICollection<Comment> Comments
        {
            get { return this.comments; }
            set { this.comments = value; }
        }
    }
}
