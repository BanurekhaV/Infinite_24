using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Day2.Controllers
{
    public class DataController : Controller
    {
        // GET: Data

        //1. Passing an object to the view that will be used as a model
        public ActionResult Index()
        {
            //List<string> flowers = new List<string>()
            //{
            //    "Roses","Lilies","Jasmine","Marigolds"
            //};
            //return View(flowers);
            List<string> finalstn;
            finalstn = TempData["stores"] as List<string>;
            return View(finalstn);
        }

        //2. Passing data thru viewbag and viewdata
        public ActionResult OfficeRules()
        {
            List<string> rule = new List<string>()
            {
                "Be on Time","Carry ID Card","Avoid T-Shirts",
                "Complete Work as per deadlines"
            };

            //1. transfer the above aboject thru viewbag
            //ViewBag.offrules = rule;
            //return View();

            //2. pass thru viewdata
            ViewData["followrules"] = rule;
            return View();
        }

        //3. checking if ViewBag or ViewData can pass on the information
        //to further request

        public ActionResult TestTransfer()
        {
            ViewBag.data1 = "Data One";
            ViewData["data2"] = "Data Two";
             return View(); // 1. In this current View, we are able to view the data

            //2. redirect to another action method of the same controller
            //return Redirect("Index");

            //3. redirect to action method of other controller
           // return RedirectToAction("Contact", "Home");
        }

        //4. using tempdata to transfer values across pages
        public ActionResult FirstTempRequest()
        {
            List<string> stationaries = new List<string>()
            {
                "Pens","Pencils","Erasers","Markers","NoteBooks"
            };
            TempData["stores"] = stationaries;
            TempData.Keep();
            // return View(); // 1. this works as usual
            return RedirectToAction("SecondTempRequest");
        }

        public ActionResult SecondTempRequest()
        {
            List<string> stnlist;
            stnlist = TempData["stores"] as List<string>;
            // TempData.Keep();
            // return View(stnlist); // working
            // return RedirectToAction("Index"); //working
            return RedirectToAction("ThirdTempRequest");
        }

        public ActionResult ThirdTempRequest()
        {
            List<string> thirdlist;
            thirdlist = TempData["stores"] as List<string>;
            //return View(thirdlist);
            return RedirectToAction("Index");
        }
    }
}