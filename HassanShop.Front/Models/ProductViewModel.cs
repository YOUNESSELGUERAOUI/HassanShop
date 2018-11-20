using Entities.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HassanShop.Front.Models
{
    public class ProductViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPage { get; set; }
        public IEnumerable<string> CategorieList { get; set; }
        public string CurrentCategory {get; set;}
    }
}
