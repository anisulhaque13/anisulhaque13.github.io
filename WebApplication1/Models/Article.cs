using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class Article
    {
        public int Id { get; set; }

        [Display(Name ="Content")]
        public string TextContent { get; set; }
        [Display(Name = "Type Of Artical")]
        public ArticleType ArticalType { get; set; }
        public virtual int ArticalTypeId { get; set; }
    }
}
