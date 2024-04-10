using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnstore_Click(object sender, EventArgs e)
        {
            ViewState["name"] = txtuname.Text;
            ViewState["pass"] = txtpassword.Text;
            txtuname.Text = " ";
            txtpassword.Text = string.Empty;
        }

        protected void btnload_Click(object sender, EventArgs e)
        {
            //inorder to go to another page we can redirect the response
            // Response.Redirect("TestForm.aspx");
            string a = ViewState["name"].ToString();
            string b = ViewState["pass"].ToString();

            //lblmsg.Text = "Your User Name is : " + a + " " + " and your Password is : " + b;
        }
    }
}