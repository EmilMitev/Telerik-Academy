using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Playlists.Models
{
    public class Rating
    {
        public int Id { get; set; }

        [Range(1,5)]
        public int Value { get; set; }

        public string AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public virtual User Author { get; set; }

        public int PlaylistId { get; set; }

        [ForeignKey("PlaylistId")]
        public virtual Playlist Playlist { get; set; }
    }
}
