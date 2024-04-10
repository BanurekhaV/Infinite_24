using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class HiddenFields : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnstore_Click(object sender, EventArgs e)
        {
            HiddenField1.Value = txtlogin.Text;
            HiddenField2.Value = txtpassword.Text;
            txtlogin.Text = " ";
            txtpassword.Text = " ";
        }

        protected void btnload_Click(object sender, EventArgs e)
        {
            lblmsg.Text = HiddenField1.Value + " " + HiddenField2.Value;
        }
    }
}