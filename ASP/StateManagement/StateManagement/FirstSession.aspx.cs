﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class FirstSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsession_Click(object sender, EventArgs e)
        {
            Session["name"] = txtbox1.Text;
            Session["city"] = txtbox2.Text;

            Response.Redirect("SecondSession.aspx");
        }
    }
}