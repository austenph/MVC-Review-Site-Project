using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Review_Site_Project.Models
{
    public class Category
    {
        [Key]
        public int CategoryID {get; set;}
        public string TechType { get; set; }

        public virtual ICollection<Reviews> Reviews { get; set; }

    }
}