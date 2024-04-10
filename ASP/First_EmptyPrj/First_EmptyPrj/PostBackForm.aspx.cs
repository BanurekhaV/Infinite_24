using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace First_EmptyPrj
{
    public partial class PostBackForm : System.Web.UI.Page
    {
        int ClicksCount = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)   //meaning it is a get request
            {
                txtcount.Text = "0";
            }
        }

        protected void BtnCount_Click(object sender, EventArgs e)
        {
            /* Step 1
            ClicksCount = ClicksCount + 1;
            txtcount.Text = ClicksCount.ToString();*/

            /*Step 2 using view state variable
            
            if (ViewState["Clicks"]!=null)
            {
                ClicksCount = (int)ViewState["Clicks"] + 1;
            }
            ViewState["Clicks"] = ClicksCount ;  //as per our program, 0 will be assigned to clicks
            txtcount.Text = ClicksCount.ToString();*/

            /*Step 3 without viewstate */
            ClicksCount = Convert.ToInt32(txtcount.Text) + 1;
            txtcount.Text = ClicksCount.ToString();
        }
    }
}