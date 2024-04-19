using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelStateEg.Models;

namespace ModelStateEg.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        //action method , if validation succeeds
        public ActionResult UserStatus()
        {
            ViewBag.Status = "Validation Successful";
            return View();
        }

        //Model Validations 
        [HttpGet]
        public ActionResult AddUser()
        {
            User umodel = new User();
            return View(umodel);
        }

        public ActionResult AddUser(User user)
        {
            if(string.IsNullOrEmpty(user.Lastname))
            {
                ModelState.AddModelError("Lastname", "please enter last name");
            }
            if(user.age <=21 || user.age>=55 )
            {
                ModelState.AddModelError("age", "Age has to be between 21 and 55");
            }

            if(!ModelState.IsValid)
            {
                return View(user);
            }
            else
            {
                TempData["LastName"] = user.Lastname;
                TempData["Age"] = user.age;
                TempData.Keep();
                return RedirectToAction("UserStatus");
            }
        }
    }

}