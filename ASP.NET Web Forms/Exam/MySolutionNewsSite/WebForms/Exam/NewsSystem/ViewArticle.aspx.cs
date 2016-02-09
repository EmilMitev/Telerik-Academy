using Microsoft.AspNet.Identity;
using NewsSystem.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.ModelBinding;
using System.Web.UI;

namespace NewsSystem
{
    public partial class ViewArticle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public Article FormViewArticle_GetItem([QueryString]string id)
        {
            if (id == null)
            {
                Response.Redirect("Default.aspx");
            }

            var articleId = int.Parse(id);

            NewsSystemDbContext db = new NewsSystemDbContext();

            var article = db.Articles
                                   .Include(x => x.Category)
                                   .Include(x => x.Likes)
                                   .Include(x => x.Author)
                                   .FirstOrDefault(x => x.Id == articleId);

            return article;
        }

        protected void ButtonLike_Click(object sender, EventArgs e)
        {
            var articleIdAsString = this.Request.QueryString["id"];

            var newLike = new Like()
            {
                Value = true,
                ArticleId = int.Parse(articleIdAsString),
                AuthorId = Page.User.Identity.GetUserId()
            };

            NewsSystemDbContext db = new NewsSystemDbContext();

            db.Likes.Add(newLike);
            db.SaveChanges();
            Response.Redirect(Request.RawUrl);
        }

        protected void ButtonDislike_Click(object sender, EventArgs e)
        {
            var articleIdAsString = this.Request.QueryString["id"];

            var newLike = new Like()
            {
                Value = false,
                ArticleId = int.Parse(articleIdAsString),
                AuthorId = Page.User.Identity.GetUserId()
            };

            NewsSystemDbContext db = new NewsSystemDbContext();

            db.Likes.Add(newLike);
            db.SaveChanges();
            Response.Redirect(Request.RawUrl);
        }
    }
}