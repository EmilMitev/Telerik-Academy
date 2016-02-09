using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Playlists.Models
{

    public class Video
    {
        public int Id { get; set; }

        public string Url { get; set; }

        [Required]
        public int PlaylistId { get; set; }

        [ForeignKey("PlaylistId")]
        public virtual Playlist Playlist { get; set; }
    }
}
