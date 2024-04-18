using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Basics.Models;

namespace MVC_Basics.Controllers
{
    public class HRController : Controller
    {
        
        //1. passing an employee object and binding it to the view
        public ActionResult DisplayEmployee()
        {
            Employee emp = new Employee() { ID = 1, Name = "Aasha", Age = 26 };
           
            return View(emp);
        }

        //2. passing list of employees to the view
        public ActionResult DisplayAllEmployees()
        {
            List<Employee> emplist = new List<Employee>()
            {
                new Employee(){ID=10, Name="Suryansh",Age=23},
                new Employee(){ID=20, Name="Kavya",Age=22},
                new Employee(){ID=30, Name="Shantanu",Age=23},
                new Employee(){ID=40, Name="Divya",Age=22},
            };
            return View(emplist);
        }

        //3. Calling a view of the same controller by passing a model object /model collection
        // GET: HR
        public ActionResult Index()
        {
            List<Department> d = new List<Department>();
            d.Add(new Department { DeptId = 1, Deptname = "IT" });
            d.Add(new Department { DeptId = 2, Deptname = "Admin" });
            d.Add(new Department { DeptId = 3, Deptname = "HR" });
            d.Add(new Department { DeptId = 4, Deptname = "Sales" });
            return View("DepartmentList",d);
        }

        //4. the called view with a list of department collection
       // public ActionResult DepartmentList(List<Department> dlist) or
       //with a depratment object
        public ActionResult DepartmentList(Department dlist)
        {
            return View(dlist);
        }

        //5. Calling view of another controller
        //contact of Home controller
        public ActionResult CallContact()
        {
            return View("~/Views/Home/Contact.cshtml");
        }
    }
}