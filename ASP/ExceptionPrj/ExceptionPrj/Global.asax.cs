using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace ExceptionPrj
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            //Exception ex = Server.GetLastError();
            //Server.ClearError();
            //Server.Transfer("~/DefaultErrors.aspx");

            //logging errors onto a file

            Exception ex = Server.GetLastError(); // getting the error
            Server.ClearError(); 
            string str = "";
            str = ex.Message; // getting the error message onto a string
           // string  innerexstr = ex.InnerException.ToString(); ;
            string path = @"C:\Banu\Infinite\B3\ASP\ExceptionPrj\ErrorLog.txt"; //file to log the errors
            File.AppendAllText(path, str);
          //  File.AppendAllText(path, innerexstr);
            Server.Transfer("~/DefaultErrors.aspx");
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}