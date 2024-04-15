using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ExceptionPrj
{
    public partial class DataLog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(Server.MapPath("~/Employees.xml"));
                Gview1.DataSource = ds;
                Gview1.DataBind();
            }
            catch(Exception ex)
            {
                ExceptionLogging.LogExceptionDB(ex);
                Label1.Text = "Some Technical Error occured.. Try after sometime";
            }

        }
    }
}