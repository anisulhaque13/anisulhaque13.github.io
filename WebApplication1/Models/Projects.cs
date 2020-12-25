using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class Projects
    {
        public int Id { get; set; }
        [Display(Name = "Project Name")]
        public string NameOfProject { get; set; }
        public string Details { get; set; }

    }
}
