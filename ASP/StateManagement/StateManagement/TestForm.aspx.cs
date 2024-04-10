using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class TestForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //view state variables of one page are not available to other pages
            //string x = ViewState["name"].ToString();
            //string y = ViewState["pass"].ToString();
            //lbldata.Text = x + " " + y;

            //hidden field values are attempted to bring to other page
          //  lbldata.Text = HiddenField1.Value + " " + HiddenField2.Value;
        }
    }
}