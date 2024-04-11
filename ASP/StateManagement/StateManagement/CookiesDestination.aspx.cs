using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class CookiesDestination : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            //persistent cookie receiving the data from the source
            //HttpCookie rc = Request.Cookies["OurTrialCookie"];
            //lbldata1.Text = rc["d1"];
            //lbldata2.Text = rc["d2"];

            //Non Persistent Cookie
        }

    }
}