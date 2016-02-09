using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Providers.Entities;

namespace NewsSystem.Models
{
    public class Like
    {
        public int Id { get; set; }

        public bool Value { get; set; }

        public string AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public virtual User Author { get; set; }

        public int ArticleId { get; set; }

        [ForeignKey("ArticleId")]
        public virtual Article Article { get; set; }
    }
}
