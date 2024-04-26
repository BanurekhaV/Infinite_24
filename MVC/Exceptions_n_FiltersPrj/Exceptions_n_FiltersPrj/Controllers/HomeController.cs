﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exceptions_n_FiltersPrj.Models;
using Exceptions_n_FiltersPrj.CustomFilter;

namespace Exceptions_n_FiltersPrj.Controllers
{
    //[Authorize]
   // [HandleError(ExceptionType = typeof(NullReferenceException),View ="NullReference")]
   // [HandleError(ExceptionType = typeof(DivideByZeroException),View ="DivideByZero")]
   // [HandleError]
   [LogCustomExceptionFilter]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            throw new Exception("Some Error Occured..");
            //return View();
        }

        public ActionResult ErrorMethod1()
        {
            throw new NullReferenceException();
        }

        public ActionResult ErrorMethod2()
        {
            throw new DivideByZeroException();
        }
        //[Authorize]
        // [Authorize(Users ="Banurekha,Admin,User1")]
        //[Authorize(Roles ="Manager,Admin,Guest")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            
            return View();
        }

        [HttpGet]
       
        public ActionResult Login(string ReturnUrl)
        {
            ViewBag.ReturnUrl = ReturnUrl;
            return View();
        }

        [HttpPost]
        [AdminFilter]
        public ActionResult Login(string UserName,string Password,bool Rememberme,string ReturnUrl)
        {
            Session["IsAdmin"] = false;
            if(UserName == "Banurekha" && Password == "banu@123")
            {
                Session["IsAdmin"] = true;
                return Redirect(ReturnUrl);
            }
            return View("Login");
        }
    }

    
}