using STOCKMASTER.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace STOCKMASTER.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string Name { get; set; }

        public bool IsActive { get; set; }
       
        public DateTime? DateCreated { get; set; }

        ICollection<Product> Products { get; set; }
    }
}
