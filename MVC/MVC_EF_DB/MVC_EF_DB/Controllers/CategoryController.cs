using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_EF_DB.Models;

namespace MVC_EF_DB.Controllers
{
    public class CategoryController : Controller
    {
        //create a context object
        NorthwindEntities db = new NorthwindEntities();
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        //1. fetch data from categories dbset/model

        public ActionResult GetCategoryDetails()
        {
            List<Category> catlist = db.Categories.ToList();
            return View(catlist);
        }

        //2. fetch category data with scafolded view

        public ActionResult GetCategoryScafolded()
        {
            List<Category> catlist = db.Categories.ToList();
            return View(catlist);
        }

        //3. Insert a new category

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //1. pass data from view to controller using model object

        [HttpPost]
        public ActionResult Create(Category c)
        {
            db.Categories.Add(c);
            db.SaveChanges();
            return RedirectToAction("GetCategoryScafolded");
        }
    }
}