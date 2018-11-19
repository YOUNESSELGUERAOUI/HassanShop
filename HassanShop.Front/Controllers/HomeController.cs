using Entities.Dao;
using HassanShop.Front.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace HassanShop.Front.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult CategorieView(string CategorieName)
        {
            ProductViewModel model = new ProductViewModel();
            model.Products = Products.Where(x => x.Categorie.Equals(CategorieName));



            //init work

            return PartialView(model);
        }

        public ActionResult Index(int page = 0, int size = 5, string categorie = "")
        {
            Products = string.IsNullOrEmpty(categorie) ? Products 
                : Products.Where(x => x.Categorie.Equals(categorie, System.StringComparison.InvariantCultureIgnoreCase));
            ProductViewModel productViewModel = new ProductViewModel
            {
                CurrentPage = page + 1,
                TotalPage = Products.Count() / size,
                Products = Products.Skip(page * size).Take(size)
            };

            if (Products.Count() % size != 0)
            {
                productViewModel.TotalPage++;
            }

            productViewModel.CategorieList = new List<string> { "imprimante", "pc", "camera", "scanner" };


            return View(productViewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Promotion(int id)
        {
            ViewBag.Message = "Your application description page.";
            return View(Products.Where(x => x.ProductId == id));
        }



        [HttpGet]
        public ActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }

            return View();
        }

        private IEnumerable<Product> _products;

        public IEnumerable<Product> Products
        {
            get
            {
                if (_products == null)
                {
                    _products = new List<Product>
                    {
                        new Product { ProductId = 1,Categorie = "imprimante", ProductName = "pc", Description ="Clavier HP sans fil  modèle 2018", HasStock = true, Price = 100 },
                        new Product { ProductId = 2,Categorie = "imprimante", ProductName = "Souris", Description ="Souris HP sans fil  modèle 2018", HasStock = true, Price = 50 },
                        new Product { ProductId = 3,Categorie = "imprimante", ProductName = "Gsm", Description ="Gsm modèle 2018", HasStock = true, Price = 1000 },
                        new Product { ProductId = 4,Categorie = "imprimante", ProductName = "pc", Description ="Clavier HP sans fil  modèle 2018", HasStock = true, Price = 100 },
                        new Product { ProductId = 5,Categorie = "imprimante", ProductName = "Souris", Description ="Souris HP sans fil  modèle 2018", HasStock = true, Price = 50 },
                        new Product { ProductId = 6,Categorie = "imprimante", ProductName = "Gsm", Description ="Gsm modèle 2018", HasStock = true, Price = 1000 },
                        new Product { ProductId = 7,Categorie = "imprimante", ProductName = "pc", Description ="Clavier HP sans fil  modèle 2018", HasStock = true, Price = 100 },
                        new Product { ProductId = 8,Categorie = "imprimante", ProductName = "Souris", Description ="Souris HP sans fil  modèle 2018", HasStock = true, Price = 50 },
                        new Product { ProductId = 9,Categorie = "imprimante", ProductName = "Gsm", Description ="Gsm modèle 2018", HasStock = true, Price = 1000 },
                        new Product { ProductId = 10,Categorie = "imprimante", ProductName = "pc", Description ="Clavier HP sans fil  modèle 2018", HasStock = true, Price = 100 },
                        new Product { ProductId = 11,Categorie = "pc", ProductName = "Souris", Description ="Souris HP sans fil  modèle 2018", HasStock = true, Price = 50 },
                        new Product { ProductId = 12,Categorie = "pc", ProductName = "Gsm", Description ="Gsm modèle 2018", HasStock = true, Price = 1000 },
                        new Product { ProductId = 13,Categorie = "pc", ProductName = "pc", Description ="Clavier HP sans fil  modèle 2018", HasStock = true, Price = 100 },
                        new Product { ProductId = 2,Categorie = "pc", ProductName = "Souris", Description ="Souris HP sans fil  modèle 2018", HasStock = true, Price = 50 },
                        new Product { ProductId = 2,Categorie = "pc", ProductName = "Gsm", Description ="Gsm modèle 2018", HasStock = true, Price = 1000 },
                        new Product { ProductId = 1,Categorie = "pc", ProductName = "pc", Description ="Clavier HP sans fil  modèle 2018", HasStock = true, Price = 100 },
                        new Product { ProductId = 2,Categorie = "pc", ProductName = "Souris", Description ="Souris HP sans fil  modèle 2018", HasStock = true, Price = 50 },
                        new Product { ProductId = 2,Categorie = "pc", ProductName = "Gsm", Description ="Gsm modèle 2018", HasStock = true, Price = 1000 },
                        new Product { ProductId = 1,Categorie = "pc", ProductName = "pc", Description ="Clavier HP sans fil  modèle 2018", HasStock = true, Price = 100 },
                        new Product { ProductId = 2,Categorie = "pc", ProductName = "Souris", Description ="Souris HP sans fil  modèle 2018", HasStock = true, Price = 50 },
                        new Product { ProductId = 2,Categorie = "pc", ProductName = "Gsm", Description ="Gsm modèle 2018", HasStock = true, Price = 1000 },
                        new Product { ProductId = 1,Categorie = "camera", ProductName = "pc", Description ="Clavier HP sans fil  modèle 2018", HasStock = true, Price = 100 },
                        new Product { ProductId = 2,Categorie = "camera", ProductName = "Souris", Description ="Souris HP sans fil  modèle 2018", HasStock = true, Price = 50 },
                        new Product { ProductId = 2,Categorie = "camera", ProductName = "Gsm", Description ="Gsm modèle 2018", HasStock = true, Price = 1000 },
                        new Product { ProductId = 1,Categorie = "camera", ProductName = "pc", Description ="Clavier HP sans fil  modèle 2018", HasStock = true, Price = 100 },
                        new Product { ProductId = 2,Categorie = "camera", ProductName = "Souris", Description ="Souris HP sans fil  modèle 2018", HasStock = true, Price = 50 },
                        new Product { ProductId = 2,Categorie = "camera", ProductName = "Gsm", Description ="Gsm modèle 2018", HasStock = true, Price = 1000 },
                        new Product { ProductId = 1,Categorie = "camera", ProductName = "pc", Description ="Clavier HP sans fil  modèle 2018", HasStock = true, Price = 100 },
                        new Product { ProductId = 2,Categorie = "camera", ProductName = "Souris", Description ="Souris HP sans fil  modèle 2018", HasStock = true, Price = 50 },
                        new Product { ProductId = 2,Categorie = "camera", ProductName = "Gsm", Description ="Gsm modèle 2018", HasStock = true, Price = 1000 },
                        new Product { ProductId = 1,Categorie = "camera", ProductName = "pc", Description ="Clavier HP sans fil  modèle 2018", HasStock = true, Price = 100 },
                        new Product { ProductId = 2,Categorie = "camera", ProductName = "Souris", Description ="Souris HP sans fil  modèle 2018", HasStock = true, Price = 50 },
                        new Product { ProductId = 2,Categorie = "camera", ProductName = "Gsm", Description ="Gsm modèle 2018", HasStock = true, Price = 1000 },
                        new Product { ProductId = 1,Categorie = "camera", ProductName = "pc", Description ="Clavier HP sans fil  modèle 2018", HasStock = true, Price = 100 },
                        new Product { ProductId = 2,Categorie = "camera", ProductName = "Souris", Description ="Souris HP sans fil  modèle 2018", HasStock = true, Price = 50 },
                        new Product { ProductId = 2,Categorie = "scanner", ProductName = "Gsm", Description ="Gsm modèle 2018", HasStock = true, Price = 1000 },
                        new Product { ProductId = 1,Categorie = "scanner", ProductName = "pc", Description ="Clavier HP sans fil  modèle 2018", HasStock = true, Price = 100 },
                        new Product { ProductId = 2,Categorie = "scanner", ProductName = "Souris", Description ="Souris HP sans fil  modèle 2018", HasStock = true, Price = 50 },
                        new Product { ProductId = 2,Categorie = "scanner", ProductName = "Gsm", Description ="Gsm modèle 2018", HasStock = true, Price = 1000 },
                        new Product { ProductId = 1,Categorie = "scanner", ProductName = "pc", Description ="Clavier HP sans fil  modèle 2018", HasStock = true, Price = 100 },
                        new Product { ProductId = 2,Categorie = "scanner", ProductName = "Souris", Description ="Souris HP sans fil  modèle 2018", HasStock = true, Price = 50 },
                        new Product { ProductId = 1,Categorie = "scanner", ProductName = "pc", Description ="Clavier HP sans fil  modèle 2018", HasStock = true, Price = 100 },
                        new Product { ProductId = 2,Categorie = "scanner", ProductName = "Souris", Description ="Souris HP sans fil  modèle 2018", HasStock = true, Price = 50 },
                        new Product { ProductId = 2,Categorie = "scanner", ProductName = "Gsm", Description ="Gsm modèle 2018", HasStock = true, Price = 1000 },
                        new Product { ProductId = 1,Categorie = "scanner", ProductName = "pc", Description ="Clavier HP sans fil  modèle 2018", HasStock = true, Price = 100 },
                        new Product { ProductId = 2,Categorie = "scanner", ProductName = "Souris", Description ="Souris HP sans fil  modèle 2018", HasStock = true, Price = 50 },
                        new Product { ProductId = 2,Categorie = "scanner", ProductName = "Gsm", Description ="Gsm modèle 2018", HasStock = true, Price = 1000 },
                        new Product { ProductId = 1,Categorie = "scanner", ProductName = "pc", Description ="Clavier HP sans fil  modèle 2018", HasStock = true, Price = 100 },
                        new Product { ProductId = 2,Categorie = "scanner", ProductName = "Souris", Description ="Souris HP sans fil  modèle 2018", HasStock = true, Price = 50 },
                        new Product { ProductId = 2,Categorie = "scanner", ProductName = "Gsm", Description ="Gsm modèle 2018", HasStock = true, Price = 1000 },
                        new Product { ProductId = 1,Categorie = "scanner", ProductName = "pc", Description ="Clavier HP sans fil  modèle 2018", HasStock = true, Price = 100 },
                        new Product { ProductId = 2,Categorie = "scanner", ProductName = "Souris", Description ="Souris HP sans fil  modèle 2018", HasStock = true, Price = 50 },
                        new Product { ProductId = 2,Categorie = "scanner", ProductName = "Gsm", Description ="Gsm modèle 2018", HasStock = true, Price = 1000 },
                        new Product { ProductId = 1,Categorie = "scanner", ProductName = "pc", Description ="Clavier HP sans fil  modèle 2018", HasStock = true, Price = 100 },
                        new Product { ProductId = 2,Categorie = "scanner", ProductName = "Souris", Description ="Souris HP sans fil  modèle 2018", HasStock = true, Price = 50 },
                        new Product { ProductId = 2,Categorie = "scanner", ProductName = "Gsm", Description ="Gsm modèle 2018", HasStock = true, Price = 1000 },
                        new Product { ProductId = 1,Categorie = "scanner", ProductName = "pc", Description ="Clavier HP sans fil  modèle 2018", HasStock = true, Price = 100 },
                        new Product { ProductId = 2,Categorie = "scanner", ProductName = "Souris", Description ="Souris HP sans fil  modèle 2018", HasStock = true, Price = 50 },
                        new Product { ProductId = 2,Categorie = "scanner", ProductName = "Gsm", Description ="Gsm modèle 2018", HasStock = true, Price = 1000 },
                        new Product { ProductId = 1,Categorie = "scanner", ProductName = "pc", Description ="Clavier HP sans fil  modèle 2018", HasStock = true, Price = 100 },
                        new Product { ProductId = 2,Categorie = "scanner", ProductName = "Souris", Description ="Souris HP sans fil  modèle 2018", HasStock = true, Price = 50 },
                    };
                }
                return _products;
            }
            set { _products = value; }
        }
    }
}