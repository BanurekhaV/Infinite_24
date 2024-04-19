using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModelPrj.Models;

namespace ViewModelPrj.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EmployeeDetails()
        {
            //collect Employee info
            Employee emp = new Employee()
            {
                EmployeeID = 111,
                EmpName = "Mahesh",
                Department = "IT",
                Salary = 35000,
                AddressID = 1
            };

            //collect Address info
            Address addr = new Address()
            {
                AddressID = 1,
                City = "Hyderabad",
                State = "Telangana",
                Country = "India"
            };

            //create a view Model object
            EmployeeAddress empadd = new EmployeeAddress()
            {
                employee = emp,
                address = addr,
                PageTitle = "Employee Personal Details"
            };

            //pass the viewmodel object to the view
            return View(empadd);
        }
    }
}