using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class CookiesSource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnRedirect_Click(object sender, EventArgs e)
        {
            //Persistent cookie
            // HttpCookie hc = new HttpCookie("OurTrialCookie");
            // hc["d1"] = txtuname.Text;
            // hc["d2"] = txtpassword.Text;
            // //we can set the time limit for the cookie objects accessibility as below
            //// hc.Expires = DateTime.Now.AddMinutes(5);
            // Response.Cookies.Add(hc);
            // Response.Redirect("CookiesDestination.aspx");

            //Non-Persistent Cookie
            Response.Cookies["uname"].Value = txtuname.Text;
            Response.Cookies["pswd"].Value = txtpassword.Text;
            Response.Redirect("CookiesDestination.aspx");

        }
    }
}