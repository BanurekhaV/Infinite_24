using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomModelBinding.CustomBinders;
using CustomModelBinding.Models;

namespace CustomModelBinding.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index([ModelBinder(typeof(CustomDataBinder))]CustomModel cs)
        {
            ViewBag.Title = cs.Title;
            ViewBag.Date = cs.Date;
            return View(cs);
        }

        public ActionResult BundleMethod()
        {
            return View();
        }
    }
}