using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;


namespace Exceptions_n_FiltersPrj.CustomFilter
{
    public class TrackerFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string message = "\n" + filterContext.ActionDescriptor.ControllerDescriptor.ControllerName +
                "-> " + filterContext.ActionDescriptor.ActionName + "-> OnActionExecuting \t - " +
                DateTime.Now.ToString();
            LogExecutionTime(message);
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            string message = "\n" + filterContext.ActionDescriptor.ControllerDescriptor.ControllerName +
                "-> " + filterContext.ActionDescriptor.ActionName + "-> OnActionExecuted \t - " +
                DateTime.Now.ToString();
            LogExecutionTime(message);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            string message = filterContext.RouteData.Values["controller"].ToString() +
                " -> " + filterContext.RouteData.Values["action"].ToString() + " -> OnResultExecuting \t -" +
                DateTime.Now.ToString();
            LogExecutionTime(message);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            string message = filterContext.RouteData.Values["controller"].ToString() +
                " -> " + filterContext.RouteData.Values["action"].ToString() + " -> OnResultExecuted \t -" +
                DateTime.Now.ToString();
            LogExecutionTime(message);
        }

        private void LogExecutionTime(string data)
        {
            File.AppendAllText(HttpContext.Current.Server.MapPath("~/ErrorLog/Data.txt"), data);
        }
    }
}