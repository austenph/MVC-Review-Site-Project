using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Review_Site_Project.Models
{
    public class Reviews
    {
        [Key]
        public int ReviewID { get; set; }
        public string ReviewContent { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Rating { get; set; }
        public string Summary { get; set; }
        public string ProductName { get; set; }
        public string CompanyName { get; set; }
        public int Price { get; set; }

        [ForeignKey("Category")]//primary key in Category table
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}