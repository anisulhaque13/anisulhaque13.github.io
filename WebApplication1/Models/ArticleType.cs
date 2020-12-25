using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class ArticleType
    {
        public int Id { get; set; }

        [Display(Name = "Type Name")]
        public string TypeName { get; set; }

    }
}
