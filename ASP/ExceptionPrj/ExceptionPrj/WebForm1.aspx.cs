using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ExceptionPrj
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          //  try
           // {
                DataSet ds = new DataSet();
                ds.ReadXml(Server.MapPath("~/Employees.xml"));
                Gview1.DataSource = ds;
                Gview1.DataBind();
          //  }
            //catch(System.IO.FileNotFoundException fnf)
            //{
            //    lblmsg.Text = "File could not be found";
            //}
        }

        //protected void Page_Error(object sender, EventArgs e)
        //{
        //    Exception ex = Server.GetLastError();
        //    Server.ClearError();
        //    Server.Transfer("~/Errors.aspx");
        //    //Response.Redirect("~/Errors.aspx");
        //}
    }
}