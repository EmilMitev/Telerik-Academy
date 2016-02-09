using Playlists.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Playlists
{
    public partial class Home : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        public IQueryable<Playlist> ListViewPopularPlaylists_GetData()
        {
            PlaylistDbContext db = new PlaylistDbContext();
            var popularPlaylists = db.Playlists
                .Include(x => x.Category)
                .Include(x => x.Ratings)
                .Include(x => x.Author)
                .Where(a => a.Ratings.Count == 0 || a.Ratings.Sum(l => l.Value) > 0)
                .OrderByDescending(a => a.Ratings.Sum(l => l.Value))
                .ThenBy(a => a.DateCreated).Take(10); ;

            return popularPlaylists;
        }
    }
}