using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_EF_DB.Models;

namespace MVC_EF_DB.Controllers
{
    public class ShipperController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Shipper
        public ActionResult Index()
        {
            return View(db.Shippers.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // 2. passing data from the view to the controller using form collection
        [HttpPost]

        //public ActionResult Create(FormCollection frm)
        //{
        //    Shipper s = new Shipper();
        //    s.ShipperID = Convert.ToInt32(frm["ShipperID"]);
        //    s.CompanyName = frm["CompanyName"].ToString();
        //    s.Phone = frm["Phone"].ToString();
        //    db.Shippers.Add(s);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        // 3. passing data from view to controller using parameters
        //we need to create parameters that match the schema columns
        public ActionResult Create(string CompanyName, string Phone)
        {
            Shipper ship = new Shipper();
           // ship.ShipperID = ShipperID;
            ship.CompanyName = CompanyName;
            ship.Phone = Phone;
            db.Shippers.Add(ship);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //calling procedure with Input Values

        public ActionResult SPWithParameter()
        {
            return View(db.CustOrdersOrders("WOLZA"));
        }
    }
}