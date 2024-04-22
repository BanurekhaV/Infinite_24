using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlHelpersprj.Models;

namespace HtmlHelpersprj.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        //1. strongly typed Helper

        public ActionResult StronglyTypedHelper()
        {
            return View();
        }

        //2. Templated helper

        public ActionResult TemplatedHelper()
        {
            return View();
        }

        //3. Tenplated helper for the entire model

        public ActionResult TemplateForModel()
        {
            return View();
        }

        //4. diplay template

        public ActionResult SDetails()
        {
            Student stud = new Student()
            {
                RollNo = 1,
                Name = "Rohit",
                Address = "Mumbai"
            };
            ViewData["studdetails"] = stud;
            return View();
           // return View(stud);
        }

        public ActionResult Standardhelper()
        {
            return View();
        }
    }

}