using NewsSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsSystem
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Article> RepeaterHomeArticles_GetData()
        {
            NewsSystemDbContext db = new NewsSystemDbContext();
            var popularArticles = db.Articles
                                   .Include(x => x.Category)
                                   .Include(x => x.Likes)
                                   .Include(x => x.Author)
                                   .OrderByDescending(a => a.Likes.Count)
                                   .Take(3);
            return popularArticles;
        }

        public IQueryable<Category> RepeaterAllCategories_GetData()
        {
            NewsSystemDbContext db = new NewsSystemDbContext();
            var allCategories = db.Categories.OrderBy(c => c.Name);
            return allCategories;
        }
    }
}