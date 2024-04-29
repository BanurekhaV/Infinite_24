using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;
using SessionStaeteEg.Models;

namespace SessionStaeteEg.Controllers
{
    [SessionState(SessionStateBehavior.Default)]
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(EmpModel obj)
        {
            //let us store the session from the user input and display into the view
            Session["Name"] = Convert.ToString(obj.Name);
            return View();
        }
    }
}