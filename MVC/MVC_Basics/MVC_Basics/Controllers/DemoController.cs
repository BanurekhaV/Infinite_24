using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Basics.Models;

namespace MVC_Basics.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        //public ActionResult Index()
        //{
        //    return View();
        //}

         //1. Normal Method
         public string NormalMethod()
        {
            return "Hi All !!";
        }

        //2. Actionmethod
        public ActionResult FirstMethod()
        {
            return View();
        }

        //3. ViewResult

        public ViewResult SecondMethod()
        {
            return View();
        }

        //4. display either html or plain text
        public ContentResult Reply()
        {
            // return Content("Good Afternoon All", "text/plain");
            return Content("<h1 style=color:blue;>Good AfterNoon All</h1>", "text/html");
        }

        //5. Empty Result
        [NonAction]
        public EmptyResult CalcResult()
        {
            int amount = 45000;
            float Si = (amount * 3 * 2) / 100;
            return new EmptyResult();
        }

        //6. Json Result
        public JsonResult EmpData()
        {
            Employee emp = new Employee() { ID = 101, Name = "Raja", Age = 31 };
            return Json(emp,JsonRequestBehavior.AllowGet);
        }

        //7.RedirectResult
        //redirects to an action method of either the same controller or different controller
        public RedirectResult Index()
        {
            return Redirect("Home/Index");
        }

        //8. redirecttoaction

        public ActionResult RedirectToactionmethod()
        {
            //  return RedirectToAction("Empdata"); //action method of the same controller
            return RedirectToAction("Contact","Home");
        }
    }
}