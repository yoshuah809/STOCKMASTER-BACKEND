
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace STOCKMASTER.Models
{
    public class Product
    {
        [Key]
        public int ProdID { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public float Price { get; set; }
        public int InStock { get; set; }

      
        public DateTime? DateCreated { get; set; }

        public bool isActive { get; set; }

        [ForeignKey("CategoryID")]
        [Required]
        public Category Category { get; set; }
    }
}
