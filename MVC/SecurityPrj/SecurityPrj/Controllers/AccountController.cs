using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SecurityPrj.Models;
using System.Web.Security;

namespace SecurityPrj.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User model)
        {
            using(MVC_DBEntities db= new MVC_DBEntities())
            {
                bool isValiduser = db.Users.Any(user => user.UserName.ToLower() ==
                model.UserName.ToLower() && user.UserPassword == model.UserPassword);

                if(isValiduser)
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return RedirectToAction("Index", "Employees");
                }
                ModelState.AddModelError("", "Invalid User name or Password");
                return View();
            }
        }

        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]

        public ActionResult SignUp(User model)
        {
            using(MVC_DBEntities db = new MVC_DBEntities())
            {
                db.Users.Add(model);
                db.SaveChanges();
            }
            return RedirectToAction("Login");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}