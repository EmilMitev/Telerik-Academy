namespace RealEstate.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Rating
    {
        private ICollection<User> users;

        public Rating()
        {
            this.users = new HashSet<User>();
        }

        [Key]
        public int Id { get; set; }

        [Range(0, 5)]
        public int Ratings { get; set; }

        public virtual ICollection<User> Users
        {
            get { return this.users; }
            set { this.users = value; }
        }
    }
}
