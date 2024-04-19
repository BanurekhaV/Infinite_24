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

        // pass data from view to controller using model object

        [HttpPost]
        public ActionResult Create(Category c)
        {
            db.Categories.Add(c);
            db.SaveChanges();
            return RedirectToAction("GetCategoryScafolded");
        }

        //4. delete a category

        public ActionResult Delete(int id)
        {
            Category cat = db.Categories.Find(id);
            return View(cat);
        }

        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteCategory(int id)
        {
            Category c = db.Categories.Find(id);
            db.Categories.Remove(c);
            db.SaveChanges();
            return RedirectToAction("GetCategoryScafolded");
        }

        //5. edit a category
        public ActionResult Update(int id)
        {
            Category cat = db.Categories.Find(id);
            return View(cat);
        }

        [HttpPost]
        public ActionResult Update(Category c)
        {
            Category cat = db.Categories.Find(c.CategoryID);
            cat.CategoryName = c.CategoryName;
            cat.Description = c.Description;
            cat.Picture = c.Picture;
            db.SaveChanges();
            return RedirectToAction("GetCategoryScafolded");
        }

        //6. details of a given category
        public ActionResult Details(int id)
        {
            Category c = db.Categories.Find(id);
            return View(c);
        }

        //7. get category by name which is sorted
        public ActionResult GetCategoryByName()
        {
            List<string> sortedcat = (from cat in db.Categories
                                      orderby cat.CategoryName
                                      select cat.CategoryName).ToList();

            //return View(sortedcat);
            dynamic c1 = db.Categories.OrderBy(cat => cat.CategoryName).ToList();
            //return View(c1);  // output not as expected
            List<string> scat = c1 as List<string>;

            return View(scat);
        }
    }
}