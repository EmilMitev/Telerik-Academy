using NewsSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsSystem.Private
{
    public partial class Categories : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        

        public IQueryable<Category> ListViewCategory_GetData()
        {
            NewsSystemDbContext db = new NewsSystemDbContext();
            var allCategoies = db.Categories;
            return allCategoies;
        }

        public void ListViewCategory_DeleteItem(int Id)
        {
            NewsSystemDbContext db = new NewsSystemDbContext();
            var itemToDelete = db.Categories.Find(Id);
            db.Categories.Remove(itemToDelete);
            db.SaveChanges();
        }

        public void ListViewCategory_UpdateItem(int Id)
        {
            NewsSystemDbContext db = new NewsSystemDbContext();
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

        protected void ShowInsert_Click(object sender, EventArgs e)
        {
            this.ListViewCategory.InsertItemPosition = InsertItemPosition.LastItem;
        }

        public void ListViewCategory_InsertItem()
        {
            var item = new Category();
            TryUpdateModel(item);

            if (ModelState.IsValid)
            {
                NewsSystemDbContext db = new NewsSystemDbContext();
                db.Categories.Add(item);
                db.SaveChanges();
            }
        }
    }
}