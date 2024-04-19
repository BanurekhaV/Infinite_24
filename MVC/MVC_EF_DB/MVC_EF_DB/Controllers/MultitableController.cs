using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_EF_DB.Models;

namespace MVC_EF_DB.Controllers
{
    public class MultitableController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Multitable
        public ActionResult Index()
        {
            return View();
        }

        //2. data from multiple tables
        [ActionName("MultiData")]
        public ActionResult Cust_Emp_Orders_Details()
        {
            return View(db.Orders.ToList());
        }

        //earlier with dynamic objects

        public ActionResult MultipleData()
        {
            dynamic mymodel = new ExpandoObject();
            mymodel.OrderList = db.Orders.ToList();
            mymodel.CutomerList = db.Customers.ToList();
            mymodel.EmpList = db.Employees.ToList();
            return View(mymodel);
        }
    }
}