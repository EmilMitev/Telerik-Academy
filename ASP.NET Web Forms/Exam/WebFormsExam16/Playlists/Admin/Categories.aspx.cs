using Playlists.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Playlists.Admin
{
    public partial class Categories : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        public IQueryable<Category> ListViewCategory_GetData()
        {
            PlaylistDbContext db = new PlaylistDbContext();
            var categories = db.Categories.Include(x => x.Playlists);
            return categories;
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListViewCategory_UpdateItem(int Id)
        {
            PlaylistDbContext db = new PlaylistDbContext();
            var category = db.Categories.Find(Id);
            if (category == null)
            {
                // The item wasn't found
                ModelState.AddModelError("", $"Product with id {category} was not found");
                return;
            }
            TryUpdateModel(category);
            if (ModelState.IsValid)
            {
                db.Entry(category).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void ListViewCategory_InsertItem()
        {
            var item = new Category();
            TryUpdateModel(item);

            if (ModelState.IsValid)
            {
                PlaylistDbContext db = new PlaylistDbContext();
                db.Categories.Add(item);
                db.SaveChanges();
            }
        }

        protected void ShowInsert_Click(object sender, EventArgs e)
        {
            this.ListViewCategory.InsertItemPosition = InsertItemPosition.LastItem;
        }
    }
}