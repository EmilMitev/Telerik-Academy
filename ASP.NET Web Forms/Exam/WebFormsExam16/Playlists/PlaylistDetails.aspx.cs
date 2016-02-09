using Playlists.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Playlists
{
    public partial class PlaylistDetails : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public Playlist FormViewPlaylist_GetItem([QueryString("id")]int? id)
        {
            if (id == null)
            {
                Response.Redirect("Home.aspx");
            }
            PlaylistDbContext db = new PlaylistDbContext();
            var playlist = db.Playlists.Find(id);
            return playlist;
        }

        public IQueryable<Video> ListViewVideos_GetData([QueryString("id")]int? id)
        {
            PlaylistDbContext db = new PlaylistDbContext();
            var playlistVideos = db.Playlists.Find(id).Videos.AsQueryable();

            return playlistVideos;
        }

        public void ListViewVideos_InsertItem([QueryString("id")]int id)
        {
            var item = new Video();
            item.PlaylistId = id;
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                PlaylistDbContext db = new PlaylistDbContext();
                db.Videos.Add(item);
                db.SaveChanges();
            }
        }

        public void ListViewVideos_UpdateItem(int Id)
        {
            PlaylistDbContext db = new PlaylistDbContext();
            var video = db.Videos.Find(Id);
            if (video == null)
            {
                // The item wasn't found
                ModelState.AddModelError("", $"Product with id {video} was not found");
                return;
            }
            TryUpdateModel(video);
            if (ModelState.IsValid)
            {
                db.Entry(video).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListViewVideos_DeleteItem(int Id)
        {
            PlaylistDbContext db = new PlaylistDbContext();
            var video = db.Videos.Find(Id);
            db.Videos.Remove(video);
            db.SaveChanges();
        }
    }
}