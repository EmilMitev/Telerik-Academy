namespace Playlists.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Playlist
    {
        private ICollection<Rating> ratings;
        private ICollection<Video> videos;

        public Playlist()
        {
            this.ratings = new HashSet<Rating>();
            this.videos = new HashSet<Video>();
        }

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public string AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public virtual User Author { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        public virtual ICollection<Rating> Ratings { get { return this.ratings; } set { this.ratings = value; } }
        public virtual ICollection<Video> Videos { get { return this.videos; } set { this.videos = value; } }

        [NotMapped]
        public double RatingValue
        {
            get
            {
                double x = 0.0;
                foreach (var item in Ratings)
                {
                    x += item.Value;
                }

                if (Ratings.Count == 0)
                {
                    return x;
                }
                else
                {
                    return x / Ratings.Count;
                }
            }
        }
    }
}
