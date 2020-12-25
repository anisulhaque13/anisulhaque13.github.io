using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Email { get; set; }
        [Display(Name = "Address Home")]
        public string HomeAddress { get; set; }
        [Display(Name = "Address Office")]
        public string OfficeAddress { get; set; }
        [Display(Name = "Mobile No")]
        public string MobileNo { get; set; }

    }
}
