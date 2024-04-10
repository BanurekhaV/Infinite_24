using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace First_EmptyPrj
{
    public partial class PageEvents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page Load" + "<br/>");
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("Init Complete" + "<br/>");
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Page Init" + "<br/>");
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Pre Init " + "<br/>");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Pre Render" + "<br/>");
        }
        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("Page PreLoad" + "<br/>");
        }
        protected void Page_Render(object sender, EventArgs e)
        {
            Response.Write("Page Render" + "<br/>");
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write("Page Load Complete" + "<br/>");
        }
        protected void Page_Unload(object sender, EventArgs e)
        {
           // Response.Write("Unloaded" + "<br/>");
        }

        protected void Btn_Welcome_Click(object sender, EventArgs e)
        {
            txtwish.Text = "Good Morning";
        }
    }

}