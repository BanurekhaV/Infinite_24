using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exceptions_n_FiltersPrj.CustomFilter;

namespace Exceptions_n_FiltersPrj.Controllers
{
    public class OurFilterController : Controller
    {
        // GET: ActFilter
        [TrackerFilter]
        public string Index()
        {
            return "Index Action Invoked";
        }

        [TrackerFilter]
        public string WelcomeMethod()
        {
           throw new Exception("Exception Occured");
        }
    }
}