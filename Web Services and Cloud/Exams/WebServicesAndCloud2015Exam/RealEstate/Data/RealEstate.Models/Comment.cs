namespace RealEstate.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [MinLength(10)]
        [MaxLength(500)]
        [Required]
        public string Content { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int? RealEstateId { get; set; }

        public virtual RealEstateModel RealEstate { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}
