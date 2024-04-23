using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Exceptions_n_FiltersPrj.Models
{
    public class LogCustomExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            //we shall log the exception on to a text file inside errorlog folder
            if(!filterContext.ExceptionHandled)
            {
                var exceptionmessage = filterContext.Exception.Message;
                var stackTrace = filterContext.Exception.StackTrace;
                var controllerName = filterContext.RouteData.Values["controller"].ToString();
                var actionName = filterContext.RouteData.Values["action"].ToString();
                var etype = filterContext.Exception.GetType();
                string Message = "Date : " + DateTime.Now.ToString() + ", Controller is :" +
                    " " + controllerName + " Action Method is : " + actionName +
                    "Error Message is : " + exceptionmessage + "ExceptionType is : "+ etype +
                    Environment.NewLine + "Stack Trace :" + stackTrace;

                File.AppendAllText(HttpContext.Current.Server.MapPath("~/ErrorLog/Log.txt"), Message);
                filterContext.ExceptionHandled = true;
                if (etype.Equals(typeof(System.NullReferenceException)))
                {
                    filterContext.Result = new ViewResult()
                    {
                        ViewName = "NullReference"
                    };

                }
                else if (etype.Equals(typeof(System.DivideByZeroException)))
                {
                    filterContext.Result = new ViewResult()
                    {
                        ViewName = "DivideByZero"
                    };
                }
                else
                {
                    filterContext.Result = new ViewResult()
                    {
                        ViewName= "Error"
                    };
                
                }
            }
        }
    }

}