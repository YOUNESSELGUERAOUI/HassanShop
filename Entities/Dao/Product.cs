using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dao
{
    public class Product
    {
        public int ProductId { get; set; }
        [Display(Name ="Titre")]
        public string ProductName { get; set; }
        [MinLength(10)]
        public string Description { get; set; }
        [Display(Name = "Prix")]
        [Required(ErrorMessage ="Le prix est obligatoire")]
        public double Price { get; set; }
        [Display(Name ="Stock disponible")]
        public bool HasStock { get; set; }
        //[Required(AllowEmptyStrings = false, ErrorMessage = "Image du produit obligatoire")]
        public string Image { get; set; }
        public string Categorie { get; set; }
    }
}
