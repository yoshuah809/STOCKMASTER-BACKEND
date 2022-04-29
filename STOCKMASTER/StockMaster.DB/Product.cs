
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using JsonIgnoreAttribute = System.Text.Json.Serialization.JsonIgnoreAttribute;

namespace STOCKMASTER.DB
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

        [Required]
        [ForeignKey("CategoryID")]
        public int CategoryID { get; set; }
        
        public virtual Category? Category { get; private set; }
    }
}
