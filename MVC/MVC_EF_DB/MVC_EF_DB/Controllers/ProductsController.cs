using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_EF_DB.Models;
using System.Data;
using System.Data.Entity;

namespace MVC_EF_DB.Controllers
{
    public class ProductsController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Products
        public ActionResult Index()
        {
            //we will go for eager loading of category entity, supplier entity along with product
            var products = db.Products.Include(Pl => Pl.Category).Include(Pl => Pl.Supplier);
            return View(products.ToList());
        }

        //Get : Products/Create
       public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName");
            ViewBag.SupplierID = new SelectList(db.Suppliers, "SupplierID", "CompanyName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include ="ProductID,ProductName,SupplierID,CategoryID,QuantityPerUnit," +
            "UnitPrice,UnitsInStock,UnitsOnorder,ReorderLevel,Discontinued")] Product product)
        {
            if(ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");               
            }

            //for the supplier, category dropdown
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName", product.CategoryID);
            ViewBag.SupplierID = new SelectList(db.Suppliers, "SupplierID", "CompanyName",product.SupplierID);
            return View(product);
        }
    }
}