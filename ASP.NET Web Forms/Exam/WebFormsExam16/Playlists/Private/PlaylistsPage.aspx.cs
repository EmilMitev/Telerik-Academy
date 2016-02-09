using Microsoft.AspNet.Identity;
using Playlists.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Playlists.Private
{
    public partial class PlaylistsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public IQueryable<Playlist> ListViewPlaylists_GetData()
        {
            PlaylistDbContext db = new PlaylistDbContext();
            var playlist = db.Playlists
                            .Include(x => x.Category)
                            .Include(x => x.Author)
                            .Include(x => x.Ratings)
                            .Include(x => x.Videos);

            return playlist;
        }

        public void ListViewPlaylists_InsertItem()
        {
            var item = new Playlist();
            item.DateCreated = DateTime.Now;
            item.AuthorId = User.Identity.GetUserId();

            TryUpdateModel(item);

            PlaylistDbContext db = new PlaylistDbContext();

            if (ModelState.IsValid)
            {
                db.Playlists.Add(item);
                db.SaveChanges();
            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public IQueryable<Category> DropDownListCategories_GetData()
        {
            PlaylistDbContext db = new PlaylistDbContext();
            var category = db.Categories;

            return category;
        }
    }
}