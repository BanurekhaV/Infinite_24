using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Day2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            List<string> receivedstationary;
            receivedstationary = TempData["stores"] as List<string>;
            // return View(receivedstationary);
            return RedirectToAction("Contact");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
                        
            return View();

        }

       
    }
}