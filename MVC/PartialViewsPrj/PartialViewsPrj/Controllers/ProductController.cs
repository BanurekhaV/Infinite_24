using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialViewsPrj.Models;

namespace PartialViewsPrj.Controllers
{
    public class ProductController : Controller
    {
        List<Product> productList;

        public ProductController()
        {
            productList = new List<Product>()
            {
                new Product{ProductId=1, ProductName="Shoes",Category="Accesories",
                Description="Smooth Soles for confort",Price=3500},
                 new Product{ProductId=2, ProductName="Watches",Category="Accesories",
                Description="Smart and network friendly",Price=5000},
                  new Product{ProductId=3, ProductName="Curtains",Category="Furnishings",
                Description="Valence for Windows",Price=2000},
                   new Product{ProductId=4, ProductName="Pillows",Category="Beddings",
                Description="Memory Foam for neck support",Price=2500},
            };
        }
        // GET: Product
        public ActionResult Index()
        {
            return View(productList);
        }

        public ActionResult AnotherMethod()
        {
            return View(productList);
        }

       
        public PartialViewResult GetAllproducts()
        {
           List<Product>prdLst = new List<Product>()
            {
                new Product{ProductId=1, ProductName="Shoes",Category="Accesories",
                Description="Smooth Soles for confort",Price=3500},
                 new Product{ProductId=2, ProductName="Watches",Category="Accesories",
                Description="Smart and network friendly",Price=5000},
                  new Product{ProductId=3, ProductName="Curtains",Category="Furnishings",
                Description="Valence for Windows",Price=2000},
                   new Product{ProductId=4, ProductName="Pillows",Category="Beddings",
                Description="Memory Foam for neck support",Price=2500},
            };
            return PartialView("ProductDetails", prdLst);
        }
    }
}