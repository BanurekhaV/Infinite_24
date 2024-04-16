using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebServicesClient.ServicesAtAGlance;

namespace WebServicesClient
{
    public partial class WebClient : System.Web.UI.Page
    {
        OurWebService1SoapClient client = new OurWebService1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnhello_Click(object sender, EventArgs e)
        {
            lbl1.Text = client.HelloWorld();
        }

        protected void btnmsg_Click(object sender, EventArgs e)
        {
            lbl1.Text = client.Message(txtname.Text);
        }

        protected void btnsquare_Click(object sender, EventArgs e)
        {
            float square = client.Squareroot(float.Parse(txtnum.Text));
            lbl1.Text = "The Square is : " + square.ToString();
        }
    }
}